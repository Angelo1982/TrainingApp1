using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingData.Plan
{
    public class PlanExercise : NotifyModel
    {
        private int _IdExercise;
        private int _IdPlan;

        public int IdExercise
        {
            get => _IdExercise;
            set => ChangePropertyValue(ref _IdExercise, value);
        }

        public int IdPlan
        {
            get => _IdPlan;
            set => ChangePropertyValue(ref _IdPlan, value);
        }
    }
}
