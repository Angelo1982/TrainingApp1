﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingData.Plan
{
    public class Occurence : NotifyModel
    {
        private WeekDays _Days;
        private KindOfDuration _KindOfDuration;
        private int _Duration;

        public WeekDays Days
        {
            get => _Days;
            set => ChangePropertyValue(ref _Days, value);
        }

        public KindOfDuration KindOfDuration
        {
            get => _KindOfDuration;
            set => ChangePropertyValue(ref _KindOfDuration, value);
        }

        public int Duration
        {
            get => _Duration;
            set => ChangePropertyValue(ref _Duration, value);
        }
    }
}
