using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TrainingData.Exercise;

namespace TrainingData.Routine
{
    public class RoutineEditViewModel : NotifyModel
    {
        private Routine _Routine;
        private ExerciseRepository _Repository;

        public ObservableCollection<SelectableExerciseViewModel> Exercises { get; set; }
        public Routine Routine
        {
            get => _Routine;
            set => ChangePropertyValue(ref _Routine, value);
        }

        public RoutineEditViewModel(Routine routine)
        {
            _Routine = routine;
            _Repository = ExerciseRepository.Instance;
            Exercises = new ObservableCollection<SelectableExerciseViewModel>();
            foreach (var exercise in _Repository.Exercises)
            {
                Exercises.Add(new SelectableExerciseViewModel
                {
                    IsSelected = routine.Exercises?.Where(e => exercise.Id == e).Any() ?? false,
                    Exercise = exercise
                });
            }

        }
    }
}
