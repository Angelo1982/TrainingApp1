using TrainingData;
using TrainingData.ExerciseData;

namespace TrainingApp1.ViewModel.Exercises
{
    public class SelectableExerciseViewModel : NotifyModel
    {
        private bool _IsSelected;

        public bool IsSelected
        {
            get => _IsSelected;
            set => ChangePropertyValue(ref _IsSelected, value);
        }
        public Exercise Exercise { get; set; }

    }
}
