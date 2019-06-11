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
            Console.WriteLine("An exception will occur if tests do not pass");
            
            Eight.HowManyLightsaverDoYouOwn();
            
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