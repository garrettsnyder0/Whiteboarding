using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseCharacters
{
    class ReverseCharacters
    {

        //Given a string, return a string with upper and lower case letters fliped 
        public static string ReverseChar(string input)
        {
            string lower = "abcdefghijklmnopqrstuvwxyz";
            string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string reversed = "";

            for (int i = 0; i < input.Length; i++)
            {
                //if(Char.IsLower(input[i]))
                if (lower.Contains(input[i]))
                {
                    reversed += Char.ToUpper(input[i]);
                }
                //else if(Char.IsUpper(input[i]))
                else if (upper.Contains(input[i]))
                {
                    reversed += Char.ToLower(input[i]);
                }
                else
                {
                    reversed += input[i];
                }
            }


            return reversed;
        }


        static void Main(string[] args)
        {

            Console.WriteLine("LeTuce");
            Console.WriteLine(ReverseChar("LeTuce"));
            Console.WriteLine("MiSSIssIpPi");
            Console.WriteLine(ReverseChar("MiSSIssIpPi"));
            Console.WriteLine("La-A");
            Console.WriteLine(ReverseChar("La-A"));
            Console.ReadKey();


        }
    }
}
