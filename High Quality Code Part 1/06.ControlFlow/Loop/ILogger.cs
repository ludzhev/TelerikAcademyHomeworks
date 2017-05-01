// <copyright file="ILogger.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>

namespace Loop
{
    /// <summary>
    /// Defines methods to log generic information.
    /// </summary>
    /// <typeparam name="T">Type of values to log.</typeparam>
    public interface ILogger<T>
    {
        /// <summary>
        /// Log a given generic value.
        /// </summary>
        /// <param name="value">Generic value to log.</param>
        void Log(T value);

        /// <summary>
        /// Log a given string.
        /// </summary>
        /// <param name="message">String to log.</param>
        void Log(string message);
    }
}