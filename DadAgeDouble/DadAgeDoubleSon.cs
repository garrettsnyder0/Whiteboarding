using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadAgeDouble
{
    public class DadAgeDoubleSon
    {

        //Write a method that takes dad's and son's age and returns when dads age is double the sons
        //can be in the past
        public static int FindAge(int dadCurrent, int sonCurrent)
        {
            //dad and son age at birth
            int son = 0;
            int dad = dadCurrent - sonCurrent;

            while (dad != 2*son)
            {
                dad++;
                son++;
            }

            return dad - dadCurrent;
        }

       
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
