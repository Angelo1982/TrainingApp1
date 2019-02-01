using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using TrainingData;
using TrainingData.ExerciseData;
using TrainingData.RoutineData;

namespace TrainingApp1.ViewModel.Routines
{
    public class RoutineViewModel : NotifyModel
    {
        private ExerciseRepository _ExerciseRepository;
        private int _CurrentExercise;
        private ObservableCollection<Exercise> _Exercises;
        private int _IdRoutine;

        public Routine Routine
        {
            get => RoutineRepository.Instance.Routines.First(r => r.Id == _IdRoutine); //_Uow.Routines...
            set => RaisePropertyChanged(nameof(Routine));
        }

        public RoutineViewModel(int idRoutine)
        {
            _IdRoutine = idRoutine;
            _ExerciseRepository = ExerciseRepository.Instance;//Wahrscheinlich unnötig
            Routine.PropertyChanged += OwnerRoutine_PropertyChanged;
            //Initial müssen die Routinen ins ViewModel geladen werden
            UpdateExercises();
        }

        private void OwnerRoutine_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //Wenn sich auf der Routine die Exercises geändert haben, muss das ViewModel aktualisiert werden.
            if (e.PropertyName == nameof(Routine.RoutineExercises))
                UpdateExercises();
        }



        /// <summary>
        /// Currently selected Exercise
        /// </summary>
        public Exercise CurrentExercise
        {
            get
            {
                return _ExerciseRepository.Exercises[_CurrentExercise];//_Uow...
            }
            set
            {
                int index = _ExerciseRepository.Exercises.IndexOf(value);
                if (index >= 0)
                {
                    _CurrentExercise = index;
                    RaisePropertyChanged(nameof(CurrentExercise));
                }
            }
        }

        /// <summary>
        /// List of Routines
        /// </summary>
        public ObservableCollection<Exercise> Exercises
        {
            get => _Exercises;
            set => ChangePropertyValue(ref _Exercises, value);
        }
        
        /// <summary>
        /// When the exercises are updated, this affects the listview in the underlying page, the RoutinePage.
        /// It leads to an update of the list itself
        /// </summary>
        private void UpdateExercises()
        {
            var ids = new List<int>();
            foreach(var e in Routine.RoutineExercises)
            {
                ids.Add(e.IdExercise);
            }
            Exercises = new ObservableCollection<Exercise>
                (_ExerciseRepository.Exercises.Where(e => ids.Contains(e.Id)));//_Uow..
        }


    }
}
