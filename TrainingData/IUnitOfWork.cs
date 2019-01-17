using System;

using TrainingData.Plan;

namespace TrainingData
{

    public interface IUnitOfWork
    {
        IRepository<Plan.Plan> Plans { get; }
        IRepository<Occurence> Occurences { get; }
        IRepository<Routine.Routine> Routines { get; }
        IRepository<Exercise.Exercise> Exercises { get; }
        void Commit();
    }

}