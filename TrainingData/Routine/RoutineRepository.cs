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
        private static int _RoutineExerciseId = 1;
        public static int GetRoutineExerciseId()
        {
            return ++_RoutineExerciseId;
        }

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
            
            Routines = new ObservableCollection<Routine>{
                    new Routine
                    {
                        Id = 0,
                        Title = "Core",
                        Description = "Baue einen starken Rumpf auf.",
                        RoutineExercises = new List<RoutineExercise>
                        {
                            new RoutineExercise{Id = GetRoutineExerciseId(), IdExercise = 1, IdRoutine = 0},
                            new RoutineExercise{Id = GetRoutineExerciseId(), IdExercise = 3, IdRoutine = 0},
                        }
                    },
                    new Routine
                    {
                        Id = 1,
                        Title = "Upper Body",
                        Description = "Baue starke Arme, Schultern und Rücken auf",
                        RoutineExercises = new List<RoutineExercise>
                        {
                            new RoutineExercise{Id = GetRoutineExerciseId(), IdExercise = 1, IdRoutine = 1},
                            new RoutineExercise{Id = GetRoutineExerciseId(), IdExercise = 2, IdRoutine = 1},
                            new RoutineExercise{Id = GetRoutineExerciseId(), IdExercise = 3, IdRoutine = 1},
                        }
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
