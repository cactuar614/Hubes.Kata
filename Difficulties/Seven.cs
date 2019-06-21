using System;
using System.Diagnostics;
using System.Linq;

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

        public static void GetMiddle()
        {
            Debug.Assert(GetMiddle("test") == "es");
            Debug.Assert(GetMiddle("Middle") == "dd");
            Debug.Assert(GetMiddle("A") == "A");
        }

        public static string GetMiddle(string s)
        {
            return s.Length%2==0 ? s.Substring((s.Length-1)/2,2) : s.Substring(s.Length/2,1);
        }

        public static void FindShort()
        {
            Debug.Assert(FindShort("bitcoin take over the world maybe who knows perhaps") == 3);
            Debug.Assert(FindShort("turns out random test cases are easier than writing out basic ones") == 3);
        }

        public static int FindShort(string s)
        {
            return s.Split(' ').OrderBy(x => x.Length).First().Length;
        }

        public static void IsPangram()
        {
            Debug.Assert(IsPangram("The quick brown fox jumps over the lazy dog"));
            Debug.Assert(!IsPangram("The quik brown fox jumps over the lazy dog"));
        }

        public static bool IsPangram(string str)
        {
            return str.ToLower().ToCharArray().Where(x => Char.IsLetter(x)).Distinct().Count() == 26;
        }
    }
}