﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using TrainingData.Exercise;

namespace TrainingData.Routine
{
    public class RoutineViewModel : NotifyModel
    {
        private ExerciseRepository _ExerciseRepository;
        private int currentExercise;
        private ObservableCollection<Exercise.Exercise> _Exercises;
        public int _IdRoutine { get; }

        public Routine Routine
        {
            get => RoutineRepository.Instance.Routines.First(r => r.Id == _IdRoutine);
            set => RaisePropertyChanged(nameof(Routine));
        }

        public RoutineViewModel(int idRoutine)
        {
            _IdRoutine = idRoutine;
            _ExerciseRepository = ExerciseRepository.Instance;
            Routine.PropertyChanged += OwnerRoutine_PropertyChanged;
            //Initial müssen die Routinen ins ViewModel geladen werden
            UpdateExercises();
        }

        private void OwnerRoutine_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //Wenn sich auf der Routine die Exercises geändert haben, muss das ViewModel aktualisiert werden.
            if (e.PropertyName == nameof(Exercises))
                UpdateExercises();
        }



        /// <summary>
        /// Currently selected Exercise
        /// </summary>
        public Exercise.Exercise CurrentExercise
        {
            get
            {
                return _ExerciseRepository.Exercises[currentExercise];
            }
            set
            {
                int index = _ExerciseRepository.Exercises.IndexOf(value);
                if (index >= 0)
                {
                    currentExercise = index;
                    RaisePropertyChanged(nameof(CurrentExercise));
                }
            }
        }

        /// <summary>
        /// List of Routines
        /// </summary>
        public ObservableCollection<Exercise.Exercise> Exercises
        {
            get => _Exercises;
            set => ChangePropertyValue(ref _Exercises, value);
        }
        

        private void UpdateExercises()
        {
            Exercises = new ObservableCollection<Exercise.Exercise>(_ExerciseRepository.Exercises.Where(e => Routine.Exercises.Contains(e.Id)));
        }
    }
}