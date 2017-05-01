using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Assertions
{
    public class SearchEngine
    {
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            bool isArrayNull = arr == null;
            bool isValueNull = value == null;

            // Debug Guard Clause
            Debug.Assert(!isArrayNull, "AssertionsHomework.SearchEngine.BinarySearch cannot work with null argument as array to search throgh!");
            Debug.Assert(!isValueNull, "AssertionsHomework.SearchEngine.BinarySearch cannot work with null argument as value to search for!");

            // Release Guard Clause
            if (isArrayNull)
            {
                throw new ArgumentNullException(nameof(arr), "AssertionsHomework.SearchEngine.BinarySearch cannot work with null argument as array to search throgh!");
            }

            if (isValueNull)
            {
                throw new ArgumentNullException(nameof(value), "AssertionsHomework.SearchEngine.BinarySearch cannot work with null argument as value to search for!");
            }

            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(IReadOnlyList<T> arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            // Debug Guard Clause
            bool isArrayNull = arr == null;
            Debug.Assert(!isArrayNull, "AssertionsHomework.SearchEngine.BinarySearch cannot work with null argument as array to search throgh!");

            bool isValueNull = value == null;

            Debug.Assert(!isValueNull, "AssertionsHomework.SearchEngine.BinarySearch cannot work with null argument as value to search for!");

            bool isStartIndexInRange = 0 <= startIndex || startIndex <= endIndex;
            Debug.Assert(isStartIndexInRange, "AssertionsHomework.SearchEngine.BinarySearch cannot work with invalid argument as start index!");

            bool isEndIndexInRange = startIndex <= endIndex || endIndex < arr.Count;
            Debug.Assert(isEndIndexInRange, "AssertionsHomework.SearchEngine.BinarySearch cannot work with invalid argument as end index!");

            // Release Guard Clause
            if (isArrayNull)
            {
                throw new ArgumentNullException(nameof(arr), "AssertionsHomework.SearchEngine.BinarySearch cannot work with null argument as array to search throgh!");
            }

            if (isValueNull)
            {
                throw new ArgumentNullException(nameof(value), "AssertionsHomework.SearchEngine.BinarySearch cannot work with null argument as value to search for!");
            }

            if (!isStartIndexInRange)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "AssertionsHomework.SearchEngine.BinarySearch cannot work with invalid argument as start index!!");
            }

            if (!isEndIndexInRange)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex), "AssertionsHomework.SearchEngine.BinarySearch cannot work with invalid argument as end index!!");
            }
            
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
    }
}
