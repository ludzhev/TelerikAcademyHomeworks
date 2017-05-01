using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Assertions
{
    public class Sorter
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            bool isArrayNull = arr == null;

            // Debug Guard Clause
            Debug.Assert(!isArrayNull, "AssertionsHomework.Sorter.SelectionSort cannot work with null argument as array to sort!");

            // Release Guard Clause
            if (isArrayNull)
            {
                throw new ArgumentNullException(nameof(arr), "AssertionsHomework.Sorter.SelectionSort cannot work with null argument as array to sort!");
            }

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }

        private static int FindMinElementIndex<T>(IReadOnlyList<T> arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            // Debug Guard Clause
            bool isArrayNull = arr == null;
            Debug.Assert(!isArrayNull, "AssertionsHomework.Sorter.FindMinElementIndex cannot work with null argument as array to sort!");

            bool isStartIndexInRange = 0 <= startIndex || startIndex <= endIndex;
            Debug.Assert(isStartIndexInRange, "AssertionsHomework.Sorter.FindMinElementIndex cannot work with invalid argument as start index!");

            bool isEndIndexInRange = startIndex <= endIndex || endIndex < arr.Count;
            Debug.Assert(isEndIndexInRange, "AssertionsHomework.Sorter.FindMinElementIndex cannot work with invalid argument as end index!");

            // Release Guard Clause
            if (isArrayNull)
            {
                throw new ArgumentNullException(nameof(arr), "AssertionsHomework.Sorter.FindMinElementIndex cannot work with null argument as array to sort!");
            }

            if (!isStartIndexInRange)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "AssertionsHomework.Sorter.FindMinElementIndex cannot work with invalid argument as start index!");
            }

            if (!isEndIndexInRange)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex), "AssertionsHomework.Sorter.FindMinElementIndex cannot work with invalid argument as end index!");
            }

            int minElementIndex = startIndex;

            bool isFirstElementNull = arr[startIndex] == null;

            // Debug Guard Clause
            Debug.Assert(!isFirstElementNull, $"AssertionsHomework.Sorter.FindMinElementIndex cannot work with array containing null element at index: {startIndex}!");

            // Release Guard Clause
            if (isFirstElementNull)
            {
                throw new ArgumentNullException($"AssertionsHomework.Sorter.FindMinElementIndex cannot work with array containing null element at index: {startIndex}!");
            }

            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                bool isCurrentElementNull = arr[i] == null;

                // Release Guard Clause
                if (isCurrentElementNull)
                {
                    throw new ArgumentNullException($"AssertionsHomework.Sorter.FindMinElementIndex cannot work with array containing null element at index: {i}!");
                }
                
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        private static void Swap<T>(ref T firstElement, ref T secondElement)
        {
            bool isFirstElementNull = firstElement == null;
            bool isSecondElementNull = secondElement == null;

            // Debug Guard Clause
            Debug.Assert(!isFirstElementNull, "AssertionsHomework.Sorter.Swap cannot work with null argument as first element to swap!");
            Debug.Assert(!isSecondElementNull, "AssertionsHomework.Sorter.Swap cannot work with null argument as second element to swap!");

            // Release Guard Clause
            if (isFirstElementNull)
            {
                throw new ArgumentNullException(nameof(firstElement), "AssertionsHomework.Sorter.Swap cannot work with null argument as element to swap!");
            }

            if (isSecondElementNull)
            {
                throw new ArgumentNullException(nameof(secondElement), "AssertionsHomework.Sorter.Swap cannot work with null argument as element to swap!");
            }
            
            T firstElementReference = firstElement;
            firstElement = secondElement;
            secondElement = firstElementReference;
        }
    }
}
