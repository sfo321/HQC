using System;
using System.Diagnostics;

namespace Assertions_Homework
{
    public static class ArraySort
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr.Length > 0, "Lenght of array passed must be at least 1");
            Debug.Assert(arr != null, "Array passed cannot be null");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr.Length > 0, "Lenght of array passed must be at least 1");
            Debug.Assert(arr != null, "Array passed cannot be null");
            Debug.Assert(startIndex < endIndex, "startIndex must be smaller than the endIndex");
            Debug.Assert(startIndex >= 0, "startIndex must be non-negative value");
            Debug.Assert(startIndex < arr.Length, "startIndex cannot be greater than the index of the last element");
            Debug.Assert(endIndex < arr.Length, "endIndex cannot be greater than the index of the last element");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }
            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}
