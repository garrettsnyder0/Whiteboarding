using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAngle
{
    class TimeAngle
    {

        //Given hour and minute calculate the angle between the hands on a clock
        public static int AngleBetweenHands(int hour, int min)
        {
            int angle = 0;
            int oneDiff = 30; //30 degrees between each number 360/12

            if(min == 0)
            {
                min = 12;
            }
            else
            {
                min = min / 5;
            }

            if(hour > min)
            {
                angle = hour - min;
            }
            else
            {
                angle = min - hour;
            }

            angle *= oneDiff;

            if(angle > 180)
            {
                angle -= 180;
            }

            return angle;
        }

        //Given hour and minute calculate the angle between the hands on a clock
        //Way 2
        //Now account for hour hand not being on hour
        public static double AngleBetweenHands2(int hour, int min)
        {
            double angle = 0;
            double oneDiff = 30;

            double hourAngle = (double)hour * oneDiff;
            hourAngle += ((30.0 / 60.0) * (min)); // travle 30 degrees in 60 min
            double minAngle = 360;
            if(min != 0)
            {
                minAngle = (double)(min / 5) * oneDiff;
            }
           

            if (hourAngle > minAngle)
            {
                angle = hourAngle - minAngle;
            }
            else
            {
                angle = minAngle - hourAngle;
            }

            

            if (angle > 180)
            {
                angle -= 180;
            }

            return angle;
        }



        static void Main(string[] args)
        {

            Console.WriteLine(AngleBetweenHands(3,00));
            Console.WriteLine(AngleBetweenHands(6, 45));
            Console.WriteLine(AngleBetweenHands(2, 15));
            Console.WriteLine(AngleBetweenHands(12, 00));
            Console.WriteLine(AngleBetweenHands(10, 30));
            
            Console.WriteLine(AngleBetweenHands2(3, 00));
            Console.WriteLine(AngleBetweenHands2(6, 45));
            Console.WriteLine(AngleBetweenHands2(2, 15));
            Console.WriteLine(AngleBetweenHands2(12, 00));
            Console.WriteLine(AngleBetweenHands2(10, 30));

            Console.ReadKey();
        }
    }
}
