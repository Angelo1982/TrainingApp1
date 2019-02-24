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
        private Routine _Routine;

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

        public Routine Routine
        {
            get => _Routine;
            set => ChangePropertyValue(ref _Routine, value);
        }
    }
}
