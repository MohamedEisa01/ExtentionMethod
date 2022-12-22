using System;

namespace ExtentionMethod
{
    public static class DateExtentions
    {
        public static bool IsWeekend(this DateTime value)
        {
            return value.DayOfWeek == DayOfWeek.Friday || value.DayOfWeek == DayOfWeek.Friday;
        }

        public static bool IsWorkDay(this DateTime value)
        {
            return !IsWeekend(value);
        }
    }

}
