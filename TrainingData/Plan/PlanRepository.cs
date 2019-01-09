using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using Common;

namespace TrainingData.Plan
{
    public class PlanRepository
    {
        /// <summary>
        /// The list of available flags
        /// </summary>
        public ObservableCollection<Plan> Plans { get; private set; }

        private static PlanRepository _Instance;
        public static PlanRepository Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new PlanRepository();
                return _Instance;
            }
        }

        private PlanRepository()
        {

            Plans = new ObservableCollection<Plan>{
                    new Plan
                    {
                        Id = 0,
                        Start = new DateTime(2019, 1, 1),
                        IdOccurence = 0,
                        PlanRoutines = new List<PlanRoutine>()

                    },
                    new Plan
                    {
                        Id = 1,
                    }
            };
            SortPlans();
        }

        public void Add(Plan Plan)
        {
            Plan.Id = Plans.GetNewId();
            Plans.Add(Plan);
            SortPlans();
        }

        public void SortPlans()
        {
            Plans.Sort((a, b) => a.Title.CompareTo(b.Title));
        }
    }
}
