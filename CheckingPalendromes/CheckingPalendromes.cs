using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingPalendromes
{
    public class CheckingPalendromes
    {

        //Given a string and return whether or not is a palendrome
        public static bool IsPalendrome(string input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] != input[input.Length-1-i])
                {
                    return false;
                }
            }
            return true;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(IsPalendrome("racecar"));
            Console.WriteLine(IsPalendrome("race car"));
            Console.ReadKey();
        }
    }
}
