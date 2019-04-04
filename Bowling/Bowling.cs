using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    class Bowling
    {

        //method that creates bowling triangle, 3 spaces after each pin
        public static void SetPins(int numPins)
        {
            int numRows = 0;
            int lastPin = numPins + 1;
            while(numPins > 0)
            {
                numRows++;
                numPins -= numRows;  
            }
            if(numPins < 0)
            {
                Console.WriteLine("Not a valid number for correct triangle");
                return;
            }
            int curRow = numRows;
            for(int i = 0; i < numRows; i++)
            {
                for(int j = 0; j < i*2; j++)
                {
                    Console.Write(" ");
                }
                for(int j = lastPin - curRow; j < lastPin; j++)
                {
                    if (j < 10)
                    {
                        Console.Write($"{j}   ");
                    }
                    else
                    {
                        Console.Write($"{j}  ");
                    }
                }
                lastPin -= curRow;
                curRow--;
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            SetPins(28);
            Console.ReadKey();
        }
    }
}
