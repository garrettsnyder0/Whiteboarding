using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetizeString
{
    public class AlphabetizeString
    {

        public static string Alphabetize(string userInput)
        {
            string ordered = "";
            int minIndex = 0;
            userInput = userInput.ToLower();
            char[] input = userInput.ToCharArray();

            char min = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] < min)
                    {
                        min = input[j];
                        minIndex = j;
                    }
                }
                ordered += min;                
                if(i != input.Length - 1)
                {
                    input[minIndex] = (char)255;
                    min = input[i + 1];   
                    minIndex = i + 1;
                }
            }

            return ordered;

        }

        static void Main(string[] args)
        {

            Console.WriteLine(Alphabetize("IAmWorking"));

            Console.ReadKey();
        }
    }
}
