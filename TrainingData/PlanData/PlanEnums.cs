using System;

namespace TrainingData.PlanData
{
    /// <summary>
    /// Working with Flags: You can say myFlags.HasFlag(WeekDays.Monday). This way you don't need a switch to find out if 
    /// Monday was set on myFlags. It is set like WeekDays myFlags = WeekDays.Monday | WeekDays.Friday;
    /// </summary>
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
