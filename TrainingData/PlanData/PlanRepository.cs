using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using Common;

namespace TrainingData.PlanData
{
    public class PlanRepository
    {
        /// <summary>
        /// The list of available flags
        /// </summary>
        public List<Plan> Plans { get; private set; }

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
            Plans = TrainingContext.Instance.Plans;
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
            //Plans.Sort((a, b) => a.Title.CompareTo(b.Title));
        }
    }
}
