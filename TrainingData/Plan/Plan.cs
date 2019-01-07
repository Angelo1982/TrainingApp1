using System;
using System.Collections.Generic;

namespace TrainingData.Plan
{
    public class Plan : NotifyModel
    {
        private string _Title;
        private string _Description;
        private int _Id;
        private List<PlanRoutine> _PlanRoutines;
        private DateTime _Start;
        private DateTime _End;
        private int _Duration;

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

        public DateTime Start
        {
            get => _Start;
            set => ChangePropertyValue(ref _Start, value);
        }

        public DateTime End
        {
            get => _End;
            set => ChangePropertyValue(ref _End, value);
        }

        

        public List<PlanRoutine> PlanRoutines
        {
            get => _PlanRoutines;
            set => ChangePropertyValue(ref _PlanRoutines, value);
        }

        /// <summary>
        /// Duration in minutes
        /// </summary>
        public int Duration
        {
            get => _Duration;
            set => ChangePropertyValue(ref _Duration, value);
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
