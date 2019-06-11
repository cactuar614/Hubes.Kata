using System;
using System.Diagnostics;


namespace Hubes.Kata.Difficulties
{
    public static class Eight
    {
        
        public static void HowManyLightsaverDoYouOwn()
        {
            Debug.Assert(Eight.HowManyLightsabersDoYouOwn("Adam") == 0);
            Debug.Assert(Eight.HowManyLightsabersDoYouOwn("Zach") == 18);
        }
        
        public static int HowManyLightsabersDoYouOwn(string name)
        {
            return name.Equals("zach", StringComparison.InvariantCultureIgnoreCase) ? 18 : 0;
        }
    }
}