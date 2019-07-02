using System;
using System.Diagnostics;
using System.Linq;

namespace Hubes.Kata.Difficulties
{
    public static class Difficulty6
    {
        public static void IsAValidWalk()
        {
            Debug.Assert(IsAValidWalk(new string[] {"n","s","n","s","n","s","n","s","n","s"}));
            Debug.Assert(!IsAValidWalk(new string[] {"w","e","w","e","w","e","w","e","w","e","w","e"}));
            Debug.Assert(!IsAValidWalk(new string[] {"w"}));
            Debug.Assert(!IsAValidWalk(new string[] {"n","n","n","s","n","s","n","s","n","s"}));
        }

        public static bool IsAValidWalk(string[] walk)
        {
            var ezLongitude = 0;
            var ezLatitude = 0;

            if (walk.Length != 10)
            {
                return false;
            }
            
            walk.ToList().ForEach(x =>
            {
                switch (x.ToLower())
                {
                    case "n":
                    {
                        ezLatitude++;
                        break;
                    }
                    case "s":
                    {
                        ezLatitude--;
                        break;
                    }
                    case "e":
                    {
                        ezLongitude++;
                        break;
                    }
                    case "w":
                    {
                        ezLongitude--;
                        break;
                    }
                }
            });

            return ezLatitude == 0 && ezLongitude == 0;
        }
    }
}