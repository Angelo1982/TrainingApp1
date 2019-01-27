using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TrainingData.ExerciseData
{
    public class SelectableExerciseViewModel : NotifyModel
    {
        private bool _IsSelected;

        public bool IsSelected
        {
            get => _IsSelected;
            set => ChangePropertyValue(ref _IsSelected, value);
        }
        public Exercise Exercise { get; set; }

    }
}
