// <copyright file="Printer.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>

using System;
using System.Collections.Generic;

namespace DataAndExpressions
{
    /// <summary>
    /// Represent a Printer of specific arithmetic operations.
    /// </summary>
    public class Printer
    {
        /// <summary>
        /// External class responsible to the log operations.
        /// </summary>
        private readonly ILogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="Printer" /> class.
        /// </summary>
        /// <param name="logger">External class responsible to the log operations.</param>
        public Printer(ILogger logger)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger), "Logger cannot be null!");
            }

            this.logger = logger;
        }

        /// <summary>
        /// Print the minimal, maximal and average values of a given sequence.
        /// </summary>
        /// <param name="elements">Sequence witch statistics will be printed.</param>
        public void PrintStatistics(ICollection<double> elements)
        {
            double maxElement = double.MinValue;
            double minElement = double.MaxValue;
            double sum = 0;

            foreach (double currentElement in elements)
            {
                maxElement = (currentElement > maxElement) ? currentElement : maxElement;
                minElement = (currentElement < minElement) ? currentElement : minElement;
                sum += currentElement;
            }

            this.logger.Log(maxElement);
            this.logger.Log(minElement);

            double average = sum / elements.Count;

            this.logger.Log(average);
        }
    }
}
