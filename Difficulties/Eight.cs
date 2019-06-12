using System;
using System.Diagnostics;
using System.Linq;
using System.Transactions;


namespace Hubes.Kata.Difficulties
{
    public static class Eight
    {
        public static void HowManyLightsaverDoYouOwn()
        {
            Debug.Assert(HowManyLightsabersDoYouOwn("Adam") == 0);
            Debug.Assert(HowManyLightsabersDoYouOwn("Zach") == 18);
        }
        
        public static int HowManyLightsabersDoYouOwn(string name)
        {
            return name.Equals("zach", StringComparison.InvariantCultureIgnoreCase) ? 18 : 0;
        }
        
        public static void ToJadenCase()
        {
            Debug.Assert(ToJadenCase("How can mirrors be real if our eyes aren't real") != "How can mirrors be real if our eyes aren't real");
            Debug.Assert(ToJadenCase("How can mirrors be real if our eyes aren't real") == "How Can Mirrors Be Real If Our Eyes Aren't Real");
        }
        
        public static string ToJadenCase(string phrase)
        {
            foreach (var s in phrase.Split(' '))
            {
                phrase = phrase.Replace(s, s.First().ToString().ToUpper() + s.Substring(1));
            }

            return phrase;
        }

        public static void ReverseWords()
        {
            Debug.Assert("world! hello" == ReverseWords("hello world!"));
            Debug.Assert("this like speak doesn't yoda" == ReverseWords("yoda doesn't speak like this"));
            Debug.Assert("foobar" == ReverseWords("foobar"));
            Debug.Assert("kata editor" == ReverseWords("editor kata"));
            Debug.Assert("boat your row row row" == ReverseWords("row row row your boat"));
        }

        public static string ReverseWords(string str)
        {
            return String.Join(' ', str.Split(' ', StringSplitOptions.None).Reverse());
        }
    }
}