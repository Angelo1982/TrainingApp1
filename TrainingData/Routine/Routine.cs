using System.Collections.Generic;

namespace TrainingData.Routine
{
    public class Routine : NotifyModel
    {
        private string _Title;
        private string _Description;
        private List<RoutineExercise> _RoutineExercises;

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
        public List<RoutineExercise> RoutineExercises
        {
            get => _RoutineExercises;
            set => ChangePropertyValue(ref _RoutineExercises, value);
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
