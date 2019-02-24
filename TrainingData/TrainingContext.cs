using System;
using System.Collections.Generic;
using System.Text;
using TrainingData.ExerciseData;
using TrainingData.PlanData;
using TrainingData.RoutineData;

namespace TrainingData
{
    public class TrainingContext
    {
        public List<Plan> Plans;
        public List<Occurence> Occurences;
        public List<ExecutiveExercise> ExecutiveExercises;
        public List<Routine> Routines;
        public List<PlanRoutine> PlanRoutines;

        private static TrainingContext _Instance;
        //private object lockObject = null;
        public static TrainingContext Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new TrainingContext();

                return _Instance;
            }
        }

        private TrainingContext()
        {
            Occurences = new List<Occurence>()
            {
                new Occurence
                {
                    Id = 1,
                    Days = WeekDays.Monday | WeekDays.Wednesday,
                    Duration = 2,
                    KindOfDuration = KindOfDuration.Weeks
                },
                new Occurence
                {
                    Id = 2,
                    Days = WeekDays.Thursday | WeekDays.Tuesday,
                    Duration = 1,
                    KindOfDuration = KindOfDuration.Years
                },
                new Occurence
                {
                    Id = 3,
                    Days = WeekDays.Friday,
                    Duration = 3,
                    KindOfDuration = KindOfDuration.Months
                }
            };

            ExecutiveExercises = new List<ExecutiveExercise>
            {
                new ExecutiveExercise
                {
                    IsPlanExercise = true,
                    Id = 0,
                    IdPlanPath = 0,
                    IdExercise = 0,
                    Exercise = Exercises.Find(e => e.Id == 0)
                },
                new ExecutiveExercise
                {
                    Id = 1,
                    IdPlanPath = 1,
                    IdExercise = 1,
                    Exercise = Exercises.Find(e => e.Id == 1)
                },
                new ExecutiveExercise
                {
                    Id = 2,
                    IdPlanPath = 2,
                    IdExercise = 2,
                    Exercise = Exercises.Find(e => e.Id == 2)
                }
            };

            Routines = new List<Routine>
            {
                new Routine
                {
                    Id = 0,
                    Title = "Core",
                    Description = "Baue einen starken Rumpf auf.",
                    RoutineExercises = RoutineExercises.FindAll(re => re.IdRoutine == 0)
                },
                new Routine
                {
                    Id = 1,
                    Title = "Upper Body",
                    Description = "Baue starke Arme, Schultern und Rücken auf",
                    RoutineExercises = RoutineExercises.FindAll(re => re.IdRoutine == 1)
                }
            };

            PlanRoutines = new List<PlanRoutine>
            {
                new PlanRoutine
                {
                    Id = 0,
                    IdPlan = 0,
                    IdRoutine = 0,
                    Routine = Routines.Find(e => e.Id == 0)
                },
                new PlanRoutine
                {
                    Id = 1,
                    IdPlan = 1,
                    IdRoutine = 1,
                    Routine = Routines.Find(e => e.Id == 1)
                },
                new PlanRoutine
                {
                    Id = 2,
                    IdPlan = 2,
                    IdRoutine = 2,
                    Routine = Routines.Find(e => e.Id == 2)
                }
            };

            Plans = new List<Plan>
            {
                new Plan
                {
                    Id = 0,
                    Start = new DateTime(2019, 1, 1, 12, 0, 0),
                    End = new DateTime(2019, 1, 1, 13, 30, 0),
                    IdOccurence = 1,
                    Occurence = Occurences.Find(o => o.Id == 1),
                    PlanExercises = ExecutiveExercises.FindAll(ee => ee.IdPlanPath == 0 && ee.IsPlanExercise),
                    PlanRoutines = PlanRoutines.FindAll(pr => pr.IdPlan == 0)
                },
                new Plan
                {
                    Id = 1,
                    Start = new DateTime(2019, 1, 10, 16, 30, 0),
                    End = new DateTime(2019, 1, 10, 17, 30, 0),
                    IdOccurence = 2,
                    Occurence = Occurences.Find(o => o.Id == 2),
                    PlanExercises = ExecutiveExercises.FindAll(ee => ee.IdPlanPath == 1 && ee.IsPlanExercise),
                    PlanRoutines = PlanRoutines.FindAll(pr => pr.IdPlan == 1)
                },
                new Plan
                {
                    Id = 2,
                    Start = new DateTime(2019, 1, 20, 20, 0, 0),
                    End = new DateTime(2019, 1, 20, 21, 30, 0),
                    IdOccurence = 3,
                    Occurence = Occurences.Find(o => o.Id == 3),
                    PlanExercises = ExecutiveExercises.FindAll(ee => ee.IdPlanPath == 2 && ee.IsPlanExercise),
                    PlanRoutines = PlanRoutines.FindAll(pr => pr.IdPlan == 2)
                }
            };
        }

        public List<Exercise> Exercises = new List<Exercise>()
        {
            new Exercise
            {
                Id = 1,
                Title = "Planks",
                Description = "Auf Ellbogen augstützen, Körper wie ein Brett. Becken nach innen kippen, Bauch anspannen"
            },
            new Exercise
            {
                Id = 2,
                Title = "Klimmzug",
                Description = "Bauch anspannen, Arme Ellbogenbreit, zuerst die Schulterblätter anspannen"
            },
            new Exercise
            {
                Id = 3,
                Title = "Liegestütze",
                Description = "Körper wie ein Brett. Mit der Nase den Boden berühren"
            }
        };

        #region Routine
        private static int _RoutineExerciseId = 1;
        public static int GetRoutineExerciseId()
        {
            return ++_RoutineExerciseId;
        }

        public List<RoutineExercise> RoutineExercises = new List<RoutineExercise>
        {
            new RoutineExercise{Id = 0, IdExercise = 1, IdRoutine = 0},
            new RoutineExercise{Id = 1, IdExercise = 3, IdRoutine = 0},
            new RoutineExercise{Id = 2, IdExercise = 1, IdRoutine = 1},
            new RoutineExercise{Id = 3, IdExercise = 2, IdRoutine = 1},
            new RoutineExercise{Id = 4, IdExercise = 3, IdRoutine = 1}
        };

        #endregion

        //public List<PlanRoutineExercise> PlanRoutineExercises = new List<PlanRoutineExercise>
        //{
        //    new PlanRoutineExercise
        //    {
        //        Id = 0,
        //        IdPlanRoutine = 0,
        //        IdRoutineExercise = 0,
        //        Exercise = Instance.RoutineExercises.Find(e => e.Id == 0).Exercise
        //    },
        //    new PlanRoutineExercise
        //    {
        //        Id = 1,
        //        IdPlanRoutine = 1,
        //        IdRoutineExercise = 1,
        //        Exercise = Instance.RoutineExercises.Find(e => e.Id == 1).Exercise
        //    },
        //    new PlanRoutineExercise
        //    {
        //        Id = 2,
        //        IdPlanRoutine = 2,
        //        IdRoutineExercise = 2,
        //        Exercise = Instance.RoutineExercises.Find(e => e.Id == 2).Exercise
        //    }
        //};

        public List<Set> Sets = new List<Set>
        {
            new Set{Id = 0, IdExecutiveExercise=0,Repetitions=10},
            new Set{Id = 1, IdExecutiveExercise=0,Repetitions=10},
            new Set{Id = 2, IdExecutiveExercise=0,Repetitions=8},
            new Set{Id = 3, IdExecutiveExercise=1,Repetitions=8},
            new Set{Id = 4, IdExecutiveExercise=1,Repetitions=12},
            new Set{Id = 5, IdExecutiveExercise=2,Repetitions=12},
            new Set{Id = 6, IdExecutiveExercise=2,Repetitions=12},
        };

    }
}
