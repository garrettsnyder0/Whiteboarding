using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingLetters
{
    class CountingLetters
    {

        //Given a string print how many time each letter occurs
        public static void CountTheLetters(string input)
        {
            input = input.ToUpper();
            int[] letters = new int[26];

            foreach(char c in input)
            {
                if (Char.IsLetter(c))
                {
                    letters[c - 'A']++;
                }
            }

            for(int i = 0; i < letters.Length; i++)
            {
                if(letters[i] > 0)
                {
                    Console.WriteLine($"{(char)('A' + i)} {letters[i]}");
                }
            }
        }


        static void Main(string[] args)
        {

            CountTheLetters("Job is working on this");


            Console.ReadKey();
        }
    }
}
