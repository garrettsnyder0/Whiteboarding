using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetizeArray
{
    class AlphabetizeArray
    {

        //Given an array of strings alphabetize and return
        public static string[] Alphabetize(string[] input)
        {
            string[] sort = new string[input.Length];
            int[] index = new int[input.Length];
            for(int i = 0; i < input.Length; i++)
            {
                index[i] = i;
                sort[i] = input[i];
            }
            string temp = "";
            string min = sort[0];
            int minIndex = 0;
            for(int i = 0; i < sort.Length; i++)
            {
                for(int j = i + 1; j < sort.Length; j++)
                {
                    for(int k = 0; k < min.Length; k++)
                    {
                        if(k > sort[j].Length)
                        {
                            break;
                        }
                        if (min[k] < sort[j][k])
                        {
                            break;
                        }
                        else if (sort[j][k] < min[k])
                        {
                            minIndex = j;
                            min = sort[j];
                            break;
                        }
                        else if(k == min.Length - 1)
                        {
                            if(min.Length > sort[j].Length)
                            {
                                minIndex = j;
                                min = sort[j];
                            }
                        }
                    }
                }
                if (minIndex != i)
                {
                    temp = sort[i];
                    sort[i] = sort[minIndex];
                    sort[minIndex] = temp;
                }
                index[i] = minIndex;
                if (i != sort.Length - 1)
                {
                    min = sort[i + 1];
                    minIndex = i + 1;
                }

            }
            return sort;
        }


        static void Main(string[] args)
        {
            string[] input = { "Garrett", "Darwin", "Job", "Bryan" };
            input = Alphabetize(input);
            for(int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }

            Console.ReadKey();
        }
    }
}
