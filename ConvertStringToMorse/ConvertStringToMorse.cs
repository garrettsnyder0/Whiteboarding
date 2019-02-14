using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringToMorse
{
    public class ConvertStringToMorse
    {

        //Given a string return converted to morse code
        public static string ConvertMorse(string input)
        {
            string[] morseLetters = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
                "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-",
                ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            string[] morseNumbers = { "-----", ".----", "..---", "...--", "....-",
                ".....", "-....", "--...", "---..", "----." };
            string converted = "";
            input = input.ToUpper();
            for(int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]))
                {
                    converted += morseLetters[input[i] - 'A'];
                }
                else if (Char.IsDigit(input[i]))
                {
                    converted += morseNumbers[Int32.Parse(input[i].ToString())];
                }
                else
                {
                    converted += input[i];
                }
                converted += " ";
            }

            return converted;
        }


        static void Main(string[] args)
        {

            Console.WriteLine(ConvertMorse("12Hey34"));

            Console.ReadKey();

        }
    }
}
