using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class AnagramProgram
    {
        static void Main(string[] args)
        {
            string name1 = "ábc";
            string name2 = "cáb";
            bool result = IsAnagram(name1, name2);
            bool result2 = IsAnagram2(name1, name2);

            Console.WriteLine("Is it an anagram {0}", result);
            Console.WriteLine("Is it an anagram {0}", result2);
            Console.ReadLine();
        }

        public static bool IsAnagram(String textOne, String textTwo)
        {
            textOne = textOne.Normalize();
            textTwo = textTwo.Normalize();

            if (textOne == "" || textTwo == "") return false;
            else if (textOne.Length != textTwo.Length) return false;

            while (textOne.Length > 0)
            {
                char first = textOne[0];
                string search = new string(first, 1);
                if (Char.IsHighSurrogate(first))
                {
                    char second = textOne[1]; //Assumed to work - if it doesn't, the input was malformed
                    search = new string(new char[] { first, second });
                }
                int index = textTwo.IndexOf(search);
                if (index < 0) return false;
                textTwo = (index > 0 ? textTwo.Substring(0, index) : "") + textTwo.Substring(index + search.Length);
                textOne = textOne.Substring(search.Length);
            }
            return true;
        }

        public static bool IsAnagram2(String s, String t)
        {
            s = s.Normalize();
            t = t.Normalize();

            if (s == "" || t == "") return false;
            else if (s.Length != t.Length) return false;

            while (s.Length > 0)
            {
                char first = s[0];
                string search = new string(first, 1);
                if (Char.IsHighSurrogate(first))
                {
                    char second = s[1]; //Assumed to work - if it doesn't, the input was malformed
                    search = new string(new char[] { first, second });
                }
                int index = t.IndexOf(search);
                if (index < 0) return false;
                t = (index > 0 ? t.Substring(0, index) : "") + t.Substring(index + search.Length);
                s = s.Substring(search.Length);
            }
            return true;
        }
    }
}
