// <copyright file="StartUP.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>
// <summary>Holds the program root.</summary>

using System;

namespace Methods
{
    /// <summary>
    /// Represent the program starting point.
    /// </summary>
    public class StartUP
    {
        /// <summary>
        /// Represent the first method called in the program live.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine(Mathematics.CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(Mathematics.DigitAsString(5));

            Console.WriteLine(Mathematics.FindMax(5, -1, 3, 2, 14, 2, 3));

            Console.WriteLine(Mathematics.FormatNumber(1.3, "precision"));
            Console.WriteLine(Mathematics.FormatNumber(0.75, "percent"));
            Console.WriteLine(Mathematics.FormatNumber(2.30, "align"));

            Console.WriteLine(Mathematics.CalculateDistance(3, -1, 3, 2.5));

            bool isHorizontalLine = Mathematics.CheckHorizontalLine(-1, 2.5);
            Console.WriteLine("Horizontal? " + isHorizontalLine);

            bool isVerticalLine = Mathematics.CheckHorizontalLine(3, 3);
            Console.WriteLine("Vertical? " + isVerticalLine);

            Student peter = new Student("Peter", "Ivanov", "Sofia", new DateTime(1992, 3, 17));
            Student stella = new Student("Stella", "Markova", "Vidin", new DateTime(1993, 11, 3));

            Console.WriteLine($"{peter.FirstName} older than {stella.FirstName} -> {peter.IsOlderThan(stella)}");
        }
    }
}
