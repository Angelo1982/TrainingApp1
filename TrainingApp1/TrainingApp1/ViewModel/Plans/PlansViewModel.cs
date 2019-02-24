using System.Collections.Generic;
using TrainingData;
using TrainingData.PlanData;

namespace TrainingApp1.ViewModel.Plans
{
    public class PlansViewModel : NotifyModel
    {
        private PlanRepository _PlanRepository;
        private int _CurrentPlan;

        public PlansViewModel()
        {
            _PlanRepository = PlanRepository.Instance;
        }

        /// <summary>
        /// Currently selected Exercise
        /// </summary>
        public Plan CurrentPlan
        {
            get
            {
                return _PlanRepository.Plans[_CurrentPlan];//_Uow...
            }
            set
            {
                int index = _PlanRepository.Plans.IndexOf(value);
                if (index >= 0)
                {
                    _CurrentPlan = index;
                    RaisePropertyChanged(nameof(_PlanRepository));
                }
            }
        }

        /// <summary>
        /// List of Routines
        /// </summary>
        public List<Plan> Plans { get { return _PlanRepository.Plans; } } //_Uow.Routines.FindAll();
    }
}
