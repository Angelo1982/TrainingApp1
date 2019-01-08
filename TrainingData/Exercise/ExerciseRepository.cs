using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.ObjectModel;
using Common;

namespace TrainingData.Exercise
{
    public class ExerciseRepository
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
            var exercises = new List<Exercise>{
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

            Exercises = new ObservableCollection<Exercise>(exercises.OrderBy(e => e.Title).ToList());
        }
    }
}
