using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCoins
{
    class CountCoins
    {

        //Given a string like 'QPDNPDQ' count the coin amount and return total
        public static double GetCoinAmount(string coins)
        {
            double totalAmt = 0.0;
            coins = coins.ToUpper();

            foreach(char c in coins)
            {
                switch(c)
                {
                    case 'Q':
                        totalAmt += 0.25;
                        break;
                    case 'D':
                        totalAmt += 0.10;
                        break;
                    case 'N':
                        totalAmt += 0.05;
                        break;
                    default:
                        totalAmt += 0.01;
                        break;
                }
            }

            return totalAmt;
        }


        static void Main(string[] args)
        {

            Console.WriteLine(GetCoinAmount("QpdNqD"));

            Console.ReadKey();
        }
    }
}
