using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using Common;

namespace TrainingData.Plan
{
    public class PlanRepository
    {
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
                    Id = 1,
                    Start = new DateTime(2019, 1, 1),
                    IdOccurence = 1,
                },
                new Plan
                {
                    Id = 2,
                    Start = new DateTime(2019, 1, 10),
                    IdOccurence = 2
                },
                new Plan
                {
                    Id = 3,
                    Start = new DateTime(2019, 1, 20),
                    IdOccurence = 3
                }
            };
            SortPlans();
        }

        public void Add(Plan plan)
        {
            plan.Id = Plans.GetNewId();
            Plans.Add(plan);
            SortPlans();
        }

        public void SortPlans()
        {
            Plans.Sort((a, b) => a.Title.CompareTo(b.Title));
        }

        /// <summary>
        /// The list of available flags
        /// </summary>
        public ObservableCollection<Plan> Plans { get; private set; }
    }
}
