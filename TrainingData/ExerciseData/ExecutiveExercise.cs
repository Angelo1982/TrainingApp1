using TrainingData.ExerciseData;

namespace TrainingData.ExerciseData
{
    public class ExecutiveExercise : NotifyModel
    {
        private int _IdExercise;
        private int _IdPlanPath;

        public int IdExercise
        {
            get => _IdExercise;
            set => ChangePropertyValue(ref _IdExercise, value);
        }
        public Exercise Exercise; 

        /// <summary>
        /// Might point to a Plan directly or a PlanRoutine
        /// </summary>
        public int IdPlanPath
        {
            get => _IdPlanPath;
            set => ChangePropertyValue(ref _IdPlanPath, value);
        }

        public int Sets { get; set; }

        public bool IsPlanExercise { get; set; }
    }
}
