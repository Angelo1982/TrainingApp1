using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

using Common;

namespace TrainingData.ExerciseData
{
    public class ExerciseRepository : IRepository<Exercise>
    {

        private static ExerciseRepository _Instance;
        public static ExerciseRepository Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ExerciseRepository();
                return _Instance;
            }

        }

        public void Add(Exercise exercise)
        {
            exercise.Id = GetId();
            Exercises.Add(exercise);
            OrderExercises();
        }

        /// <inheritdoc />
        public void Remove(Exercise entity)
        {
            Exercises.Remove(entity);
        }

        /// <inheritdoc />
        public IEnumerable<Exercise> Find(Expression<Func<Exercise, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Exercise FindById(int id)
        {
            return Exercises.First(e => e.Id == id);
        }

        /// <inheritdoc />
        public IEnumerable<Exercise> FindAll()
        {
            return Exercises;
        }

        private int GetId()
        {
            var ids = Exercises.Select(r => r.Id).ToList();
            var highestId = ids.Max();
            return ++highestId;
        }

        public void OrderExercises()
        {
            Exercises.Sort((a, b) => a.Title.CompareTo(b.Title));
        }

        /// <summary>
        /// The list of available exercises
        /// </summary>
        public ObservableCollection<Exercise> Exercises { get; private set; }

        private ExerciseRepository()
        {
            Exercises = new ObservableCollection<Exercise>(TrainingContext
                .Instance
                .Exercises
                .OrderBy(e => e.Title).ToList());
        }
    }
}
