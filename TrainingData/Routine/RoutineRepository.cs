using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using Common;

namespace TrainingData.Routine
{
    public class RoutineRepository
    {
        private static RoutineRepository _Instance;
        public static RoutineRepository Instance
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
            
            Routines = new ObservableCollection<Routine>{
                    new Routine
                    {
                        Id = 0,
                        Title = "Core",
                        Description = "Baue einen starken Rumpf auf.",
                        Exercises=new HashSet<int>{1, 3}
                    },
                    new Routine
                    {
                        Id = 1,
                        Title = "Upper Body",
                        Description = "Baue starke Arme, Schultern und Rücken auf",
                        Exercises=new HashSet<int>{1, 2, 3}
                    }
            };
            SortRoutines();
        }

        public void Add(Routine routine)
        {
            routine.Id = Routines.GetNewId();
            Routines.Add(routine);
            SortRoutines();
        }

        private bool _Sorting;
        public void SortRoutines()
        {
            _Sorting = true;
            Routines.Sort((a, b) => a.Title.CompareTo(b.Title));
            _Sorting = false;
        }

        /// <summary>
        /// The list of available flags
        /// </summary>
        public ObservableCollection<Routine> Routines { get; private set; }
    }
}
