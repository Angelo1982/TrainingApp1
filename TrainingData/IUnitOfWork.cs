using System;
using System.Collections.Generic;
using System.Text;
using TrainingData.Exercise;
using TrainingData.Plan;
using TrainingData.Routine;

namespace TrainingData
{
    public interface IUnitOfWork
    {
        IRepository<PlanRepository> Plan { get; }
        IRepository<OccurenceRepository> Plan { get; }
        IRepository<RoutineRepository> Plan { get; }
        IRepository<ExerciseRepository> Plan { get; }
        void Commit();

    }
}
