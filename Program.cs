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
            
            // https://www.codewars.com/kata/51f9d93b4095e0a7200001b8
            Difficulty8.HowManyLightsaverDoYouOwn();
            
            // https://www.codewars.com/kata/jaden-casing-strings/
            Difficulty8.ToJadenCase();
            
            // https://www.codewars.com/kata/51c8991dee245d7ddf00000e
            Difficulty8.ReverseWords();
            
            // https://www.codewars.com/kata/526c7363236867513f0005ca
            Difficulty7.LeapYears();
            
            // https://www.codewars.com/kata/56747fd5cb988479af000028
            Difficulty7.GetMiddle();
            
            // https://www.codewars.com/kata/57cebe1dc6fdc20c57000ac9
            Difficulty7.FindShort();
            
            // https://www.codewars.com/kata/545cedaa9943f7fe7b000048
            Difficulty7.IsPangram();

            // https://www.codewars.com/kata/57f609022f4d534f05000024
            Difficulty7.IsUniqueNumber();
            
            // https://www.codewars.com/kata/54da539698b8a2ad76000228
            Difficulty6.IsAValidWalk();
            
            
            
            Console.WriteLine(@"                _ ");
            Console.WriteLine(@"               | |");
            Console.WriteLine(@"  ___ _ __   __| |");
            Console.WriteLine(@" / _ \ '_ \ / _` |");
            Console.WriteLine(@"|  __/ | | | (_| |");
            Console.WriteLine(@" \___|_| |_|\__,_|");
        }
    }
}