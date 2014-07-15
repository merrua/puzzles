using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortExample
{
    /// <summary>
    /// Merge sort Algorithim
    ///  O(n log n)
    ///  assuming no duplicates 
    /// </summary>
    class MergeSortAlgorithm
    {
        static void Main(string[] args)
        {
            // Example.
            int[] Values = { 10, 20, 30, 40, 50, 61, 60, 80, 81, 82 };
            
            MergeSort(Values);
            PrintArray(Values);
            Console.ReadLine();
        }

        static void MergeSort(int[] numbers)
        {
            // Base Case. 
            // If the array size is 0 or 1, return it straight away.
            if (numbers.Length <= 1)
            {
               // Console.WriteLine("We could skip the rest");
            }
            else
            {
                // Means that you don't need to rewrite this
                MergeSort(numbers, 0, numbers.Length - 1);
            }
        }

        static public void MergeSort(int[] numbers, int left, int right)
        {
            if (left < right)
            {
                int middle = (left / 2) + (right / 2);
                MergeSort(numbers, left, middle);
                MergeSort(numbers, middle + 1, right);
                Merge(numbers, left, middle, right);
            }
        }

        static public void Merge(int[] numbers, int low, int middle, int high)
        {
            int left = low;
            int right = middle + 1;
            int[] temp = new int[(high - low) + 1];
            int tempIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (numbers[left] < numbers[right])
                {
                    temp[tempIndex] = numbers[left];
                    left = left + 1;
                }
                else
                {
                    temp[tempIndex] = numbers[right];
                    right = right + 1;
                }
                tempIndex = tempIndex + 1;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    temp[tempIndex] = numbers[left];
                    left = left + 1;
                    tempIndex = tempIndex + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    temp[tempIndex] = numbers[right];
                    right = right + 1;
                    tempIndex = tempIndex + 1;
                }
            }

            for (int i = 0; i < temp.Length; i++)
            {
                numbers[low + i] = temp[i];
            }
        }

        public static string PrintArray(int[] numbers)
        {
            string result = String.Empty;
            if (numbers.Length == 0)
            {
                Console.WriteLine(result);
                return result;
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    result = result + numbers[i] + " ";
                }
                Console.WriteLine(result);
                return result;
            }
        }

    }
}
