// <copyright file="Mathematics.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>
// <summary>Holds implementation of static class Mathematics.</summary>

using System;
using System.Linq;

namespace Methods
{
    /// <summary>
    /// Represent a static class that holds mathematical methods.
    /// </summary>
    public static class Mathematics
    {
        /// <summary>
        /// Maximum difference between two double values to ignore when comparrison.
        /// </summary>
        private const double DoubleComparrisonTolerance = 0.000001;

        /// <summary>
        /// Calculate the aria of a triangle by given sides.
        /// </summary>
        /// <param name="firstSide">First side of the triangle.</param>
        /// <param name="secondSide">Second side of the triangle.</param>
        /// <param name="thirdSide">Third side of the triangle.</param>
        /// <returns>The area of the triangle.</returns>
        /// <exception cref="ArgumentException">Thrown when any of the triangle sides is negative or when is not possible to construct a triangle by them.</exception>
        public static double CalculateTriangleArea(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                throw new ArgumentException("Any of the triangle sides should be positive!");
            }

            if ((firstSide + secondSide < thirdSide) ||
                (firstSide + thirdSide < secondSide) ||
                (secondSide + thirdSide < firstSide))
            {
                throw new ArgumentException("There is no triangle with such sides!");
            }

            double halfPerimeter = (firstSide + secondSide + thirdSide) / 2;
            double quadraticArea = halfPerimeter * (halfPerimeter - firstSide) * (halfPerimeter - secondSide) * (halfPerimeter - thirdSide);
            double area = Math.Sqrt(quadraticArea);
            return area;
        }

        /// <summary>
        /// Convert a given digit as string.
        /// </summary>
        /// <param name="number">The digit to convert.</param>
        /// <returns>String representation of the digit.</returns>
        /// <exception cref="ArgumentException">Thrown when number is not one digit.</exception>
        public static string DigitAsString(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            throw new ArgumentException("Number should be one digit!");
        }

        /// <summary>
        /// Find the element with maximal value through a given collection.
        /// </summary>
        /// <param name="elements">Collection within to search for.</param>
        /// <returns>The maximal value.</returns>
        /// <exception cref="ArgumentNullException">Thrown when null is passed as argument.</exception>
        /// <exception cref="ArgumentException">Thrown when empty array is passed as argument.</exception>
        public static int FindMax(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException(nameof(elements), "Elements cannot be null!");
            }

            if (elements.Length == 0)
            {
                throw new ArgumentException("Elements cannot be empty array!");
            }

            return elements.Concat(new[] { int.MinValue }).Max();
        }

        /// <summary>
        /// Generate string representation of a given number by given format.
        /// </summary>
        /// <param name="number">The number to be represented.</param>
        /// <param name="format">The format of the representing string.</param>
        /// <returns>String representation of the given number.</returns>
        /// <exception cref="ArgumentException">Thrown when the format is different from precision, percent or align.</exception>
        public static string FormatNumber(double number, string format)
        {
            if (string.IsNullOrEmpty(format))
            {
                throw new ArgumentException("Format cannot be null or empty!");
            }

            switch (format)
            {
                case "precision":
                    return $"{number:f2}";
                case "percent":
                    return $"{number:p0}";
                case "align":
                    return $"{number,8}";
            }

            throw new ArgumentException("There is no such format!");
        }

        /// <summary>
        /// Calculate distance between two points by given coordinates.
        /// </summary>
        /// <param name="firstPointXCoordinate">First point's abscissa.</param>
        /// <param name="firstPointYCoordinate">First point's ordinate.</param>
        /// <param name="secondPointXCoordinate">Second point's abscissa.</param>
        /// <param name="secondPointYCoordinate">Second point's ordinate.</param>
        /// <returns>The distance between the points.</returns>
        /// <exception cref="OverflowException">Thrown when the calculations cannot be hold in <see cref="double"/> variable.</exception>
        public static double CalculateDistance(double firstPointXCoordinate, double firstPointYCoordinate, double secondPointXCoordinate, double secondPointYCoordinate)
        {
            double quadraticHorizontalProection = (secondPointXCoordinate - firstPointXCoordinate) * (secondPointXCoordinate - firstPointXCoordinate);
            double quadraticVerticalProection = (secondPointYCoordinate - firstPointYCoordinate) * (secondPointYCoordinate - firstPointYCoordinate);
            double quadraticProectionSum = quadraticHorizontalProection + quadraticVerticalProection;

            if (double.IsPositiveInfinity(quadraticProectionSum))
            {
                throw new OverflowException("The points are very far from each other to calculte correctly the distance!");
            }

            double distance = Math.Sqrt(quadraticProectionSum);

            return distance;
        }

        /// <summary>
        /// Check if a line is horizontal by given coordinates in the ordinate axis.
        /// </summary>
        /// <param name="firstPointYCoordinate">First point's ordinate.</param>
        /// <param name="secondPointYCoordinate">Second point's ordinate.</param>
        /// <returns>Rather the line is horizontal or not.</returns>
        public static bool CheckHorizontalLine(double firstPointYCoordinate, double secondPointYCoordinate)
        {
            bool isHorizontal = Math.Abs(firstPointYCoordinate - secondPointYCoordinate) < DoubleComparrisonTolerance;
            return isHorizontal;
        }

        /// <summary>
        /// Check if a line is vertical by given coordinates in the abscissa axis.
        /// </summary>
        /// <param name="firstPointXCoordinate">First point's abscissa.</param>
        /// <param name="secondPointXCoordinate">Second point's abscissa.</param>
        /// <returns>Rather the line is vertical or not.</returns>
        public static bool CheckVerticalLine(double firstPointXCoordinate, double secondPointXCoordinate)
        {
            bool isVertical = Math.Abs(firstPointXCoordinate - secondPointXCoordinate) < DoubleComparrisonTolerance;
            return isVertical;
        }
    }
}
