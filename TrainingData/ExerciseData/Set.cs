using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingData.ExerciseData
{
    public class Set : NotifyModel
    {
        public int Repetitions { get; set; }
        public int IdExecutiveExercise { get; set; }
        public bool IsExecutive { get; set; }

    }
}
