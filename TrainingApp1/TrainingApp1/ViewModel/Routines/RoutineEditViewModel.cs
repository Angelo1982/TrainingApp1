using System.Collections.ObjectModel;
using System.Linq;
using TrainingApp1.ViewModel.Exercises;
using TrainingData;
using TrainingData.ExerciseData;
using TrainingData.RoutineData;

namespace TrainingApp1.ViewModel.Routines
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
                    IsSelected = routine.RoutineExercises?.Where(e => exercise.Id == e.IdExercise).Any() ?? false,
                    Exercise = exercise
                });
            }

        }
    }
}
