using System.Collections.Generic;

namespace TrainingData.Routine
{
    public class Routine : NotifyModel
    {
        private string _Title;
        private string _Description;
        private HashSet<int> _Exercises;

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
        public HashSet<int> Exercises
        {
            get => _Exercises;
            set => ChangePropertyValue(ref _Exercises, value);
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
