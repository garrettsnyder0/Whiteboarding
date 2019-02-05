using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulianDate
{
    class JulianDate
    {
        //Given month and day calculate the julian date
        public static int CalcJulianDate(int month, int day)
        {
            int julian = day;
            for(int i = 1; i < month; i++)
            {
                if(i ==2)
                {
                    julian += 28;
                }
                else if(i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10)
                {
                    julian += 31;
                }
                else
                {
                    julian += 30;
                }
            }

            return julian;
        }

        //Same as above using array
        public static int CalcJulianDate2(int month, int day)
        {
            int julian = day;
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30 };

            for (int i = 1; i < month; i++)
            {
                julian += daysInMonth[i-1];
            }

            return julian;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CalcJulianDate(1, 1));
            Console.WriteLine(CalcJulianDate(2, 28));
            Console.WriteLine(CalcJulianDate(12, 31));
            Console.WriteLine(CalcJulianDate(7, 15));
            Console.WriteLine(CalcJulianDate(10, 7));

            Console.WriteLine(CalcJulianDate2(1, 1));
            Console.WriteLine(CalcJulianDate2(2, 28));
            Console.WriteLine(CalcJulianDate2(12, 31));
            Console.WriteLine(CalcJulianDate2(7, 15));
            Console.WriteLine(CalcJulianDate2(10, 7));

            Console.ReadKey();
        }
    }
}
