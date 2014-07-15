using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome1
{
    /// <summary>
    /// Palindrome
    /// </summary>

    class PalindromeProgram
    {
        static void Main(string[] args)
        {            
            const int ARRAYSIZE = 4;

            string[] textArray= new string[ARRAYSIZE];
            textArray[0] = "racecar";
            textArray[1] = "blue";
            textArray[2] = "noon";

            // Instance of the class because the main method is static.
            example ex = new example();

            // Sending each of the three strings into the palidrome method.
            string exString = textArray[0].ToString();
            bool answer = ex.PalindromeCheck(exString);
            Console.WriteLine("Its {0} that {1} is a palidrome", answer, exString);

            // pretend unit test
            // instead of writing to console it could to log.
            if (answer != true)
            {
                Console.WriteLine("Exception");
            }

            exString = textArray[1].ToString();
            answer = ex.PalindromeCheck(exString);
            Console.WriteLine("Its {0} that {1} is a palidrome", answer, exString);

            // pretend unit test
            if (answer != false)
            {
                Console.WriteLine("Exception");
            }

            exString = textArray[2].ToString();
            answer = ex.PalindromeCheck(exString);
            Console.WriteLine("Its {0} that {1} is a palidrome", answer, exString);

            Console.ReadLine();
        }

    }

    public class example
    {
        /// <summary>
        /// A function that checks if a string is a palidrome and returns true or false. 
        /// </summary>
        /// <param name="firstString">The string we are checking</param>
        /// <returns></returns>
        public bool PalindromeCheck(string firstString)
        {
            char[] exCharArray = firstString.ToCharArray();
            Array.Reverse(exCharArray);
            string reveresedString = new string(exCharArray);

            // Does the reverse string match the normal one?
            if (firstString == reveresedString)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
