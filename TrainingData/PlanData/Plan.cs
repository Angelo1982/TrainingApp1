using System;
using System.Collections.Generic;
using TrainingData.ExerciseData;

namespace TrainingData.PlanData
{
    public class Plan : NotifyModel
    {
        private string _Title;
        private string _Description;
        private List<PlanRoutine> _PlanRoutines;
        private List<ExecutiveExercise> _PlanExercises;
        private Occurence _Occurence;
        private DateTime _Start;
        private DateTime _End;
        private int _Duration;
        private int _IdOccurence;

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

        public int IdOccurence
        {
            get => _IdOccurence;
            set => ChangePropertyValue(ref _IdOccurence, value);
        }

        public Occurence Occurence
        {
            get => _Occurence;
            set => ChangePropertyValue(ref _Occurence, value);
        }

        public List<PlanRoutine> PlanRoutines
        {
            get => _PlanRoutines;
            set => ChangePropertyValue(ref _PlanRoutines, value);
        }

        /// <summary>
        /// Exercises not bound to a routine but sit directly on the plan itself
        /// </summary>
        public List<ExecutiveExercise> PlanExercises
        {
            get => _PlanExercises;
            set => ChangePropertyValue(ref _PlanExercises, value);
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
