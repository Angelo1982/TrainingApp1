using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingData.Plan
{
    public class PlanRoutine:NotifyModel
    {
        private int _IdRoutine;
        private int _IdPlan;

        public int IdRoutine
        {
            get => _IdRoutine;
            set => ChangePropertyValue(ref _IdRoutine, value);
        }

        public int IdPlan
        {
            get => _IdPlan;
            set => ChangePropertyValue(ref _IdPlan, value);
        }
    }
}
