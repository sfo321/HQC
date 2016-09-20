using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assertions_Homework
{
    public static class ArrBinarySearch
    {
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array passed cannot be null");
            Debug.Assert(arr.Length > 0, "Lenght of array passed must be at least 1");
            Debug.Assert(CheckIfSorted(arr), "Array passed must be sorted first!");

            int startIndex = 0;
            int endIndex = arr.Length - 1;

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }
                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }

        private static bool CheckIfSorted<T>(T[] arr) where T : IComparable<T>
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                if(arr[i].CompareTo(arr[i + 1]) > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
