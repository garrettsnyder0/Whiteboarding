using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes
{
    public class Primes
    {

        //Given number find if prime
        //faster code remove prime and return early
        public static bool IsPrime(int x)
        {
            //bool prime = true;
            if(x == 0 || x == 2)
            {
                //prime = false;
                return false;
            }

            for (int i = 2; i < x; i++)
            {
                if(x%i == 0)
                {
                    //prime = false;
                    return false;
                }
            }

            //return prime;
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(1));
            Console.WriteLine(IsPrime(2));
            Console.WriteLine(IsPrime(9));
            Console.WriteLine(IsPrime(13));
            Console.WriteLine(IsPrime(0));

            Console.ReadKey();
        }
    }
}
