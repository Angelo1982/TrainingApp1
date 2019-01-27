using System;

using TrainingData.PlanData;

namespace TrainingData
{

    public interface IUnitOfWork
    {
        IRepository<PlanData.Plan> Plans { get; }
        IRepository<Occurence> Occurences { get; }
        IRepository<RoutineData.Routine> Routines { get; }
        IRepository<ExerciseData.Exercise> Exercises { get; }
        void Commit();
    }

}