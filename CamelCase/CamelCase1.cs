using System;

namespace CamelCase
{
    public class CamelCase1
    {
        public static string convertToCamel(string input)
        {
            input = input.ToLower();
            string camel = "";
            char last = input[0];
            
            foreach(char c in input)
            {
                if(last == ' ' && camel.Length != 0)
                {
                    camel += Char.ToUpper(c);
                }
                else
                {
                    if(c != ' ')
                    {
                        camel += c;
                    }
                }
                last = c;
                       
            }

            
            return camel;
        }


        static void Main(string[] args)
        {

            Console.WriteLine(convertToCamel("Mary had A"));
            Console.WriteLine(convertToCamel("test Test tEsT"));
            Console.WriteLine(convertToCamel("I AM WORKING NOW"));
            Console.WriteLine(convertToCamel("    I'm a jerk test."));

            Console.ReadKey();
        }
    }
}
