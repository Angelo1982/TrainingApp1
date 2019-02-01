using System;
using TrainingData.PlanData;
using TrainingData.RoutineData;

namespace TrainingData
{

    public interface IUnitOfWork
    {
        IRepository<PlanData.Plan> Plans { get; }
        IRepository<Occurence> Occurences { get; }
        IRepository<Routine> Routines { get; }
        IRepository<ExerciseData.Exercise> Exercises { get; }
        void Commit();
    }

}