using System.ComponentModel;
using System.Runtime.CompilerServices;
using Common;

namespace TrainingData
{
    public class NotifyModel : INotifyPropertyChanged, INotifyModel
    {
        private int _Id;

        public int Id
        {
            get => _Id;
            set => ChangePropertyValue(ref _Id, value);
        }

        protected bool ChangePropertyValue<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (!Equals(field, value))
            {
                field = value;
                RaisePropertyChanged(propertyName);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Raises the INotifyPropertyChanged event.
        /// </summary>
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
