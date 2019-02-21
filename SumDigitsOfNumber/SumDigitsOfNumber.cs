using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigitsOfNumber
{
    public class SumDigitsOfNumber
    {

        //given a number return the sum of the digits until you have a single digit number
        //12345 -> 15 -> 6
        public static int SumDigitsRecursion(int input)
        {
            int sum = 0;
            while (input >= 10)
            {
                sum += (input % 10);
                input /= 10;

            }
            sum += input;
            if (sum >= 10)
            {
                sum = SumDigitsRecursion(sum);
            }

            return sum;
        }

        public static int SumDigitsLoop(int input)
        {
            int sum = 0;
            if(input < 10)
            {
                return input;
            }
            while (input >= 10)
            {
                sum = 0;
                while (input >= 10)
                {

                    sum += (input % 10);
                    input /= 10;   
                }
                sum += input;
                input = sum;
            }
            return sum;
        }


        static void Main(string[] args)
        {

            Console.WriteLine(SumDigitsRecursion(12345));
            Console.WriteLine(SumDigitsLoop(5));
            Console.ReadKey();
        }
    }
}
