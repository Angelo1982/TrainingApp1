using System.Collections.ObjectModel;
using TrainingApp1.ViewModel.Routines;
using TrainingData.ExerciseData;

namespace TrainingApp1.ViewModel.Exercises
{
    public class ExerciseViewModelWrapper : ExerciseViewModel
    {
        private readonly RoutineViewModel _Rvm;

        public ExerciseViewModelWrapper(RoutineViewModel rvm)
        {
            this._Rvm = rvm;
        }

        /// <summary>
        /// Currently selected Exercise
        /// </summary>
        public override Exercise CurrentExercise
        {
            get
            {
                return _Rvm.CurrentExercise;
            }

            set
            {
                _Rvm.CurrentExercise = value;
            }
        }

        /// <summary>
        /// List of Exercises
        /// </summary>
        public override ObservableCollection<Exercise> Exercises { get { return _Rvm.Exercises; } }
    }
}
