// <copyright file="ValueFinder.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>

using System;
using System.Collections.Generic;

namespace Loop
{
    /// <summary>
    /// Find generic value among a set of values.
    /// </summary>
    /// <typeparam name="T">Generic value to find.</typeparam>
    public class ValueFinder<T>
        where T : IComparable<T>
    {
        /// <summary>
        /// Log values taking place before given value.
        /// </summary>
        /// <param name="expectedValue">The value before witch to log.</param>
        /// <param name="values">Set of values to log.</param>
        /// <param name="logger">Logger to log the values.</param>
        public void LogValuesBeforeGivenValue(T expectedValue, IList<T> values, ILogger<T> logger)
        {
            foreach (T element in values)
            {
                if (element.CompareTo(expectedValue) == 0)
                {
                    logger.Log("Value Found");
                }
                else
                {
                    logger.Log(element);
                }
            }
        }
    }
}
