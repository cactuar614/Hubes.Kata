using System;
using Hubes.Kata.Difficulties;

namespace Hubes.Kata
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(@" _   _       _                 _   __      _        ");
            Console.WriteLine(@"| | | |     | |               | | / /     | |       ");
            Console.WriteLine(@"| |_| |_   _| |__   ___  ___  | |/ /  __ _| |_ __ _ ");
            Console.WriteLine(@"|  _  | | | | '_ \ / _ \/ __| |    \ / _` | __/ _` |");
            Console.WriteLine(@"| | | | |_| | |_) |  __/\__ \_| |\  \ (_| | || (_| |");
            Console.WriteLine(@"\_| |_/\__,_|_.__/ \___||___(_)_| \_/\__,_|\__\__,_|");
            //An exception will occur if tests do not pass
            //TODO: change behavior of passing and failing tests
            
            Eight.HowManyLightsaverDoYouOwn();
            Eight.ToJadenCase();
            Eight.ReverseWords();
            Seven.LeapYears();
            Seven.GetMiddle();
            Seven.FindShort();
            Seven.IsPangram();
            
            Console.WriteLine(@"                _ ");
            Console.WriteLine(@"               | |");
            Console.WriteLine(@"  ___ _ __   __| |");
            Console.WriteLine(@" / _ \ '_ \ / _` |");
            Console.WriteLine(@"|  __/ | | | (_| |");
            Console.WriteLine(@" \___|_| |_|\__,_|");
            Console.ReadLine();
        }
    }
}