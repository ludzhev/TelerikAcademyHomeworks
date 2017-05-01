// <copyright file="Point2D.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>
// <summary>Holds implementation of static class Mathematics.</summary>

using System;

namespace CohesionAndCoupling
{
    /// <summary>
    /// Represent a point in 2D space.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Origin abscissa coordinate.
        /// </summary>
        private const double OriginXCoordinate = 0;

        /// <summary>
        /// Origin ordinate coordinate.
        /// </summary>
        private const double OriginYCoordinate = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Point2D"/> class.
        /// </summary>
        /// <param name="abscissaCoordinate">Abscissa coordinate of the point.</param>
        /// <param name="ordinateCoordinate">Ordinate coordinate of the point.</param>
        public Point2D(double abscissaCoordinate, double ordinateCoordinate)
        {
            this.XCoordinate = abscissaCoordinate;
            this.YCoordinate = ordinateCoordinate;
        }

        /// <summary>
        /// Gets or sets the abscissa coordinate of the point.
        /// </summary>
        /// <value>Abscissa coordinate of the <see cref="Point2D"/> instance.</value>
        public double XCoordinate { get; set; }

        /// <summary>
        /// Gets or sets the ordinate coordinate of the point.
        /// </summary>
        /// <value>Ordinate coordinate of the <see cref="Point2D"/> instance.</value>
        public double YCoordinate { get; set; }

        /// <summary>
        /// Calculate distance between two points in 2D space.
        /// </summary>
        /// <param name="firstPoint">First <see cref="Point2D"/> instance.</param>
        /// <param name="secondPoint">Second <see cref="Point2D"/> instance.</param>
        /// <returns>The distance between the points.</returns>
        /// <exception cref="OverflowException">Thrown when the calculations cannot be hold in <see cref="double"/> variable.</exception>
        public static double CalculateDistance2D(Point2D firstPoint, Point2D secondPoint)
        {
            double distance = CalculateDistanceByCoordinates(firstPoint.XCoordinate, firstPoint.YCoordinate, secondPoint.XCoordinate, secondPoint.YCoordinate);

            return distance;
        }

        /// <summary>
        /// Calculate distance between two points in 2D space by given coordinates.
        /// </summary>
        /// <param name="firstPointXCoordinate">First point's abscissa.</param>
        /// <param name="firstPointYCoordinate">First point's ordinate.</param>
        /// <param name="secondPointXCoordinate">Second point's abscissa.</param>
        /// <param name="secondPointYCoordinate">Second point's ordinate.</param>
        /// <returns>The distance between the points.</returns>
        /// <exception cref="OverflowException">Thrown when the calculations cannot be hold in <see cref="double"/> variable.</exception>
        public static double CalculateDistance2D(
            double firstPointXCoordinate,
            double firstPointYCoordinate,
            double secondPointXCoordinate = OriginXCoordinate,
            double secondPointYCoordinate = OriginYCoordinate)
        {
            double distance = CalculateDistanceByCoordinates(firstPointXCoordinate, firstPointYCoordinate, secondPointXCoordinate, secondPointYCoordinate);

            return distance;
        }

        /// <summary>
        /// Calculate distance between two points in 2D space by given coordinates.
        /// </summary>
        /// <param name="firstPointXCoordinate">First point's abscissa.</param>
        /// <param name="firstPointYCoordinate">First point's ordinate.</param>
        /// <param name="secondPointXCoordinate">Second point's abscissa.</param>
        /// <param name="secondPointYCoordinate">Second point's ordinate.</param>
        /// <returns>The distance between the points.</returns>
        /// <exception cref="OverflowException">Thrown when the calculations cannot be hold in <see cref="double"/> variable.</exception>
        private static double CalculateDistanceByCoordinates(
            double firstPointXCoordinate,
            double firstPointYCoordinate,
            double secondPointXCoordinate = OriginXCoordinate,
            double secondPointYCoordinate = OriginYCoordinate)
        {
            double quadraticXProection = (secondPointXCoordinate - firstPointXCoordinate) * (secondPointXCoordinate - firstPointXCoordinate);
            double quadraticYProection = (secondPointYCoordinate - firstPointYCoordinate) * (secondPointYCoordinate - firstPointYCoordinate);

            double quadraticProectionSum = quadraticXProection + quadraticYProection;

            if (double.IsInfinity(quadraticProectionSum))
            {
                throw new OverflowException("The points are very far from each other to calculte correctly the distance!");
            }

            double distance = Math.Sqrt(quadraticProectionSum);

            return distance;
        }
    }
}
