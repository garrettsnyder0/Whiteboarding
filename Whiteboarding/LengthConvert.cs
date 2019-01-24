using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboarding
{
    public class LengthConvert
    {

        //Given a number of feet convert to inches and return the value
        public static double ConvertFeetToInch(double feet) => feet * 12;

        //Given inches convert to feet
        public static double ConvertInchToFeet(double inches) => inches / 12;

        static void Main(string[] args)
        {
            Console.WriteLine(ConvertFeetToInch(2.0));
            Console.WriteLine(ConvertFeetToInch(2.5));

            Console.ReadKey();
        }
    }
}
