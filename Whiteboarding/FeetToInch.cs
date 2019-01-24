using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboarding
{
    class FeetToInch
    {

        static double ConvertFeetToInch(double feet) => feet * 12;

        static void Main(string[] args)
        {
            Console.WriteLine(ConvertFeetToInch(2.0));
            Console.WriteLine(ConvertFeetToInch(2.5));

            Console.ReadKey();
        }
    }
}
