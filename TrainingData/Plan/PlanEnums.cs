using System;

namespace TrainingData.Plan
{
    [Flags]
    public enum WeekDays
    {
        None = 0000000,
        Monday = 0000001,
        Tuesday = 0000010,
        Wednesday = 0000100,
        Thursday = 0001000,
        Friday = 0010000,
        Saturday = 0100000,
        Sunday = 1000000
    }

    public enum KindOfDuration
    {
        Days,
        Weeks,
        Months,
        Years
    }

}
