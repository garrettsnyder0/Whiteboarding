using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeaserCypher
{
    public class CeaserCypher
    {

        public static string Encode(string input, int shift)
        {
            shift = shift % 26;
            string encoded = "";
            int temp;
            input = input.ToUpper();

            foreach(char c in input)
            {
                temp = c + shift;
                if(temp < 'A')
                {
                    temp = ('Z' + 1) - ('A' - temp);
                }
                if(temp > 'Z')
                {
                    temp = ('A' - 1) + (temp - 'Z');
                }

                encoded += (char)temp;
            }

            return encoded;
        }

        public static string Decode(string input, int shift)
        {
            shift = shift % 26;
            string decoded = "";
            int temp;
            shift = shift * -1;
            input = input.ToUpper();

            foreach (char c in input)
            {
                temp = c + shift;
                if (temp < 'A')
                {
                    temp = ('Z' + 1) - ('A' - temp);
                }
                if (temp > 'Z')
                {
                    temp = ('A' - 1) + (temp - 'Z');
                }

                decoded += (char)temp;
            }

            return decoded;
        }

        static void Main(string[] args)
        {


            Console.WriteLine(CeaserCypher.Decode((CeaserCypher.Encode("cat", 2)), 2));

            Console.ReadKey();
        }
    }
}
