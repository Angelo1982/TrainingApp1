using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingData.Routine
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

    }
}
