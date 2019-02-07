using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInt
{
    public class ReverseInt
    {
        //my way
        public static int RevInt(int input)
        {
            //string tempResult = "";
            int temp = input;
            int result = 0;
            int count = -1;
            while(temp != 0)
            {
                temp /= 10;
                count++;
            }
    

            while (input != 0)
            {
                temp = input % 10;
                input /= 10;
                //tempResult += temp;
                if (count != 0)
                {
                    result = result + (temp * (int)Math.Pow(10,count));
                    count--;
                }
                else
                {
                    result += temp;
                }
            }


            return result;
            //return Int32.Parse(tempResult);
        }


        //Dan's much easier way
        public static long Mirror(int value)
        {
            long sum = 0;
            for(int i = value; i!= 0; i = i/10)
            {
                int remainder = i % 10;
                sum = sum * 10 + remainder;
            }

            return sum;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Mirror(1073));
            Console.ReadKey();
        }
    }
}
