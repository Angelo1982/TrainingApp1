using System;
using System.Collections.Generic;
using System.Text;
using TrainingData.ExerciseData;

namespace TrainingData.RoutineData
{
    public class RoutineExercise : NotifyModel
    {
        private int _IdRoutine;
        private int _IdExercise;

        public int IdRoutine
        {
            get => _IdRoutine;
            set => ChangePropertyValue(ref _IdRoutine, value);
        }

        public int IdExercise
        {
            get => _IdExercise;
            set => ChangePropertyValue(ref _IdExercise, value);
        }
        public Exercise Exercise
        {
            get
            {
                return TrainingContext.Instance.Exercises.Find(e => e.Id == _IdExercise);
            }
        }

        public RoutineExercise()
        {
            
        }
    }
}
