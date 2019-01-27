using Common;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingData.RoutineData;

namespace TrainingData.PlanData
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
        public Routine Routine;

        public int IdPlan
        {
            get => _IdPlan;
            set => ChangePropertyValue(ref _IdPlan, value);
        }
    }
}
