using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TrainingData.Routine
{
    public class RoutinesViewModel : INotifyPropertyChanged
    {
        private RoutineRepository _Repository;
        int currentRoutine;

        public event PropertyChangedEventHandler PropertyChanged;

        public RoutinesViewModel()
        {
            _Repository = RoutineRepository.Instance;
        }

        /// <summary>
        /// Currently selected Routine
        /// </summary>
        public Routine CurrentRoutine
        {
            get
            {
                return _Repository.Routines[currentRoutine];
            }

            set
            {
                int index = _Repository.Routines.IndexOf(value);
                if (index >= 0)
                {
                    currentRoutine = index;
                    RaisePropertyChanged(nameof(CurrentRoutine));
                }
            }
        }

        /// <summary>
        /// List of Routines
        /// </summary>
        public ObservableCollection<Routine> Routines { get { return _Repository.Routines; } }

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
