using System.Collections.ObjectModel;
using System.Linq;
using Common;

namespace TrainingData.RoutineData
{
    public class RoutineRepository
    {
        private static RoutineRepository _Instance;
        public static RoutineRepository Instance //Wird wahrscheinlich unnötig
        {
            get
            {
                if (_Instance == null)
                    _Instance = new RoutineRepository();
                return _Instance;
            }
        }

        private RoutineRepository()
        {
            var trainingsContext = TrainingContext.Instance;
            var routines = trainingsContext.Routines;
            Routines = new ObservableCollection<Routine>(
                routines
                .OrderBy(e => e.Title).ToList());

            //SortRoutines();
        }

        public void Add(Routine routine)
        {
            routine.Id = Routines.GetNewId();
            Routines.Add(routine);
            SortRoutines();
        }

        public void SortRoutines()
        {
            Routines.Sort((a, b) => a.Title.CompareTo(b.Title));
        }

        /// <summary>
        /// The list of available flags
        /// </summary>
        public ObservableCollection<Routine> Routines { get; private set; }
    }
}
