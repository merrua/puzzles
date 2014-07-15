using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringHelper.ReverseString("framework"));
            Console.WriteLine(StringHelper.ReverseString2("Les Misérables"));
            Console.WriteLine(StringHelper.ReverseString2("Les Misאֳrables"));
            Console.ReadLine();
        }
    }

    static class StringHelper
    {
        /// <summary>
        /// Receives string and returns the string with its letters reversed.
        /// </summary>
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        /// <summary>
        /// Receives a unicode string and returns the string respecting special characters
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>

        public static string ReverseString2(string s)
        {
            TextElementEnumerator enumerator = StringInfo.GetTextElementEnumerator(s);

            List<string> elements = new List<string>();
            while (enumerator.MoveNext())
                elements.Add(enumerator.GetTextElement());

            elements.Reverse();
            string reversed = string.Concat(elements);
            return reversed;
        }
    }
}
