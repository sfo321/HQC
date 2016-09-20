using System;

namespace Assertions_Homework
{
    public class Startup
    {
        static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            ArraySort.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            ArraySort.SelectionSort(new int[0]); // Test sorting empty array
            ArraySort.SelectionSort(new int[1]); // Test sorting single element array            

            Console.WriteLine(ArrBinarySearch.BinarySearch(arr, -1000));
            Console.WriteLine(ArrBinarySearch.BinarySearch(arr, 0));
            Console.WriteLine(ArrBinarySearch.BinarySearch(arr, 17));
            Console.WriteLine(ArrBinarySearch.BinarySearch(arr, 10));
            Console.WriteLine(ArrBinarySearch.BinarySearch(arr, 1000));

            int[] arr2 = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine(ArrBinarySearch.BinarySearch(arr2, 0)); // Test BinarySearch in non-sorted array
        }
    }
}
