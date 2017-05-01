using System;

namespace Assertions
{
    public class StartUp
    {
        public static void Main()
        {
            var arr = new[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            Sorter.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            Sorter.SelectionSort(new int[0]); // Test sorting empty array
            Sorter.SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(SearchEngine.BinarySearch(arr, -1000));
            Console.WriteLine(SearchEngine.BinarySearch(arr, 0));
            Console.WriteLine(SearchEngine.BinarySearch(arr, 17));
            Console.WriteLine(SearchEngine.BinarySearch(arr, 10));
            Console.WriteLine(SearchEngine.BinarySearch(arr, 1000));
        }
    }
}
