using System;
using System.Diagnostics;

namespace Hubes.Kata.Difficulties
{
    public static class Seven
    {
        public static void LeapYears()
        {
            Debug.Assert(!IsLeapYear(1234));
            Debug.Assert(IsLeapYear(1984));
            Debug.Assert(IsLeapYear(2000));
            Debug.Assert(!IsLeapYear(2010));
            Debug.Assert(!IsLeapYear(2013));
            Debug.Assert(!IsLeapYearAlternate(1234));
            Debug.Assert(IsLeapYearAlternate(1984));
            Debug.Assert(IsLeapYearAlternate(2000));
            Debug.Assert(!IsLeapYearAlternate(2010));
            Debug.Assert(!IsLeapYearAlternate(2013));
        }

        public static bool IsLeapYear(int year)
        {
            return year / 4 * 4 == year && Math.Truncate((decimal)year/100) * 100 != year || Math.Truncate((decimal)year/400) * 400 == year;
        }

        public static bool IsLeapYearAlternate(int year)
        {
            return DateTime.IsLeapYear(year);
        }
    }
}