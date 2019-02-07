using System;

namespace CamelCase
{
    public class CamelCase
    {
        public static string convertToCamel(string input)
        {
            input = input.ToLower();
            string camel = "";
            char last = input[0];
            string punctuation = "`~!@#$%^&*()-_=+|]}[{';:/?.>,<";

            foreach (char c in input)
            {
                if (last == ' ' && camel.Length != 0 &&  c != ' ')
                {
                    camel += Char.ToUpper(c);
                }
                else
                {
                    if (c != ' ' && !punctuation.Contains(c.ToString()))
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

            Console.WriteLine(convertToCamel("    I'm a jerk test."));
            

            Console.ReadKey();
        }
    }
}