using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factors
{
    class Program
    {
        static void Main(string[] args)
        {
            int sample = 100;

            //printFactorsOfAnInt();
            //List<int> results = getFactorsOfAnInt(sample);

            List<int> results = getPrimesUpToANumber(sample);

            foreach (var ex in results)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private static List<int> getPrimesUpToANumber(int num1)
        {
            List<int> primes = new List<int>();

            // you actually only need to check up to sqrt(i)
            for (int i = 1; i <=num1; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        // its not a prime
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        private static List<int> getFactorsOfAnInt(int num1)
        {
            List<int> factors = new List<int>();

            for (int i = 2; i < num1; i++)
            {
                if ((num1 % i == 0) && (i != num1))
                {
                    factors.Add(i);
                }
            }

            return factors;
        }

        private static void printFactorsOfAnInt()
        {
            int num1 = 0;

            Console.WriteLine("Please enter your integer: ");
            num1 = int.Parse(Console.ReadLine());

            for (int i = 2; i < num1; i++)
            {
                if ((num1 % i == 0) && (i != num1))
                {
                    Console.WriteLine(i + " is a factor of " + num1);
                }
                else
                {
                    Console.WriteLine(i + " is not a factor of " + num1);
                }
            }
            Console.ReadLine();
        }
    }
}
