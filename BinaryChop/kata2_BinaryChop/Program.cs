using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace k_BinaryChop
{
    /// <summary>
    /// Binary Search.
    /// Assuming a presorted array of less than 100,000 its
    /// Make a Binary search to search through them.
    /// 
    /// "takes an integer search target and a sorted array of integers. 
    /// It should return the integer index of the target in the array, 
    /// or -1 if the target is not in the array."
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            
            // declares the large int array
            const int MAXARRAY = 100000;
            int[] intArray = new int[MAXARRAY];
            int values = 50;
            int searchValue = 51;

            // fill the array with sorted values.
            for (int i = 0; i < MAXARRAY; i++)
            {
                intArray[i] = values;
                values += 1;
                // Console.WriteLine(intArray[i]);
            }


            Console.WriteLine(intArray[MAXARRAY-1]);
            // Test to confirm the array has been populated.
            Debug.Assert(intArray[MAXARRAY-1] != 0, "Array is not filled.");

            // Search using default Binary Search
            // O(log(n))
            int index = Array.BinarySearch(intArray, searchValue);
            Console.WriteLine("searchvalue {0} is in the array at position {1}, proof {2}", searchValue, index, intArray[index] );

            // A linear search
            int ouput = MyLinearSearch(intArray, searchValue);

            // Now making my own version in a method
            int output2 = MyBinarySearch(intArray, searchValue);

            Console.ReadLine();
        }

        /// <summary>
        /// Linear Search
        /// </summary>
        /// <param name="intArray"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public static int MyLinearSearch(int[] intArray, int searchValue)
        {
            int _iCount = 0;
            Console.WriteLine("MyLinearSearch");

            for (int i = 0; i < intArray.Count(); i++ )
            {
                _iCount++;

                if (searchValue == intArray[i])
                {
                    Console.WriteLine("Linear Search: We found the number {0} at position {1}", searchValue, i);
                    Console.WriteLine("It took {0} cycles", _iCount );
                    return i;
                }
                
            }
            return -1;
        }


        /// <summary>
        /// Binary Search.
        /// </summary>
        public static int MyBinarySearch(int[] intArray, int searchValue)
        {
            Console.WriteLine("MyBinarySearch");
            bool found = false;

            int low = 0;
            int last = intArray.Count() - 1;
            int middle = 0;

            while (!found && low <= last)
            {
                middle = (low + last) / 2;

                if (searchValue < intArray[middle])
                {
                    low = middle + 1;
                }
                if (searchValue > intArray[middle])
                {
                    last = middle - 1;
                }
                else
                {
                    // found it and stop
                    Console.WriteLine("Binary Search: We found the number {0} at position {1}", searchValue, intArray[middle]);
                    found = true;
                }
            }

            return -1;
        }
    }
}
