using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowels
{
    class CountVowels
    {
        //passed a string count and return the number of vowels
        public static int countVowels(string input)
        {
            int vowelCount = 0;
            input = input.ToLower();

            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(countVowels("cat"));
            Console.WriteLine(countVowels("MISSISSIPPI"));
            Console.ReadKey();
        }
    }
}
