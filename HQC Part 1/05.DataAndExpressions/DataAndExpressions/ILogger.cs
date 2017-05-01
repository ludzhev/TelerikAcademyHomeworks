// <copyright file="ILogger.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>

namespace DataAndExpressions
{
    /// <summary>
    /// Defines methods to log information.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Log a given integer number.
        /// </summary>
        /// <param name="number">Integer number to log.</param>
        void Log(int number);

        /// <summary>
        /// Log a given double number.
        /// </summary>
        /// <param name="number">Double number to log.</param>
        void Log(double number);

        /// <summary>
        /// Log a given string.
        /// </summary>
        /// <param name="message">String to log.</param>
        void Log(string message);
    }
}