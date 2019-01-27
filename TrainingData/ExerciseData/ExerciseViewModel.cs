using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TrainingData.ExerciseData
{
    public class ExerciseViewModel : INotifyPropertyChanged
    {
        private ExerciseRepository _Repository;
        int currentExercise;

        public event PropertyChangedEventHandler PropertyChanged;

        public ExerciseViewModel()
        {
            _Repository = ExerciseRepository.Instance;
        }

        /// <summary>
        /// Currently selected Exercise
        /// </summary>
        public virtual Exercise CurrentExercise
        {
            get
            {
                return _Repository.Exercises[currentExercise];
            }

            set
            {
                int index = _Repository.Exercises.IndexOf(value);
                if (index >= 0)
                {
                    currentExercise = index;
                    RaisePropertyChanged(nameof(CurrentExercise));
                }
            }
        }

        /// <summary>
        /// List of Exercises
        /// </summary>
        public virtual ObservableCollection<Exercise> Exercises { get { return _Repository.Exercises; } }

        /// <summary>
        /// Raise the PropertyChanged notification.
        /// </summary>
        /// <param name="propertyName"></param>
        private void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
