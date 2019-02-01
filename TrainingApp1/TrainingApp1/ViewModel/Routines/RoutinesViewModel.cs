using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using TrainingData.RoutineData;

namespace TrainingApp1.ViewModel.Routines
{
    public class RoutinesViewModel : INotifyPropertyChanged
    {
        private RoutineRepository _Repository; //IUnitOfWork _Uow;
        int currentRoutine;

        public event PropertyChangedEventHandler PropertyChanged;

        public RoutinesViewModel()
        {
            _Repository = RoutineRepository.Instance; //_Uow = UnitOfWork.Instance;
        }

        /// <summary>
        /// Currently selected Routine
        /// </summary>
        public Routine CurrentRoutine
        {
            get
            {
                return _Repository.Routines[currentRoutine];//_Uow.Routines.FindById(currentRoutine);
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
        public ObservableCollection<Routine> Routines { get { return _Repository.Routines; } } //_Uow.Routines.FindAll();

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
