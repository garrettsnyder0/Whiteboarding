using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingEmail
{
    class CheckingEmail
    {

        //Given a string check if a valid email
        //has @ but not last or first char
        //has . after @
        //no spaces
        public static bool ValidEmail(string email)
        {
            bool inDomain = false;
            bool valid = false;
            int domainStart = 0;

            if(email[0] == '@' || email[email.Length-1] == '@')
            {
                return false;
            }

            for(int i = 0; i < email.Length; i++)
            {
                if (email[i] == ' ') break;
                if (email[i] == '@')
                {
                    inDomain = true;
                    domainStart = i + 1;
                }
                if(inDomain && email[i] == '.')
                {
                    if (i == domainStart || i == email.Length - 1) return false;
                    else valid = true;
                }
            }

            return valid;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(ValidEmail("garrettsnyder0@gmail.com"));
            Console.WriteLine(ValidEmail("thisismyemail@stuff.com  check check"));
            Console.WriteLine(ValidEmail("@notvalid"));
            Console.WriteLine(ValidEmail("notvalid@"));
            Console.WriteLine(ValidEmail("check@check"));
            Console.ReadKey();
        }
    }
}
