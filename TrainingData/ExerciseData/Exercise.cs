using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TrainingData.ExerciseData
{
    public class Exercise : NotifyModel
    {
        private string _Title;
        private string _Description;

        public string Title
        {
            get => _Title;
            set => ChangePropertyValue(ref _Title, value);
        }

        public string Description
        {
            get => _Description;
            set => ChangePropertyValue(ref _Description, value);
        }


        public override string ToString()
        {
            return Title;
        }

    }
}
