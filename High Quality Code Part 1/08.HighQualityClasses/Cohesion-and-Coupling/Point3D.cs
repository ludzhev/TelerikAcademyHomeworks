// <copyright file="Point3D.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>
// <summary>Holds implementation of static class Mathematics.</summary>

using System;

namespace CohesionAndCoupling
{
    /// <summary>
    /// Represent a point in 3D space.
    /// </summary>
    public class Point3D
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
        /// Origin applicate coordinate.
        /// </summary>
        private const double OriginZCoordinate = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Point3D"/> class.
        /// </summary>
        /// <param name="abscissaCoordinate">Abscissa coordinate of the point.</param>
        /// <param name="ordinateCoordinate">Ordinate coordinate of the point.</param>
        /// <param name="applicateCoordinate">Applicate coordinate of the point.</param>
        public Point3D(double abscissaCoordinate = OriginXCoordinate, double ordinateCoordinate = OriginYCoordinate, double applicateCoordinate = OriginZCoordinate)
        {
            this.XCoordinate = abscissaCoordinate;
            this.YCoordinate = ordinateCoordinate;
            this.ZCoordinate = applicateCoordinate;
        }

        /// <summary>
        /// Gets or sets the abscissa coordinate of the point.
        /// </summary>
        /// <value>Abscissa coordinate of the <see cref="Point3D"/> instance.</value>
        public double XCoordinate { get; set; }

        /// <summary>
        /// Gets or sets the ordinate coordinate of the point.
        /// </summary>
        /// <value>Ordinate coordinate of the <see cref="Point3D"/> instance.</value>
        public double YCoordinate { get; set; }

        /// <summary>
        /// Gets or sets the applicate coordinate of the point.
        /// </summary>
        /// <value>Applicate coordinate of the <see cref="Point3D"/> instance.</value>
        public double ZCoordinate { get; set; }

        /// <summary>
        /// Calculate distance between two points in 3D space.
        /// </summary>
        /// <param name="firstPoint">First <see cref="Point3D"/> instance.</param>
        /// <param name="secondPoint">Second <see cref="Point3D"/> instance.</param>
        /// <returns>The distance between the points.</returns>
        /// <exception cref="OverflowException">Thrown when the calculations cannot be hold in <see cref="double"/> variable.</exception>
        public static double CalculateDistance3D(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = CalculateDistanceByCoordinates(
                firstPoint.XCoordinate,
                firstPoint.YCoordinate,
                firstPoint.ZCoordinate,
                secondPoint.XCoordinate,
                secondPoint.YCoordinate,
                secondPoint.ZCoordinate);

            return distance;
        }

        /// <summary>
        /// Calculate distance between two points in 3D space by given coordinates.
        /// </summary>
        /// <param name="firstPointXCoordinate">First point's abscissa.</param>
        /// <param name="firstPointYCoordinate">First point's ordinate.</param>
        /// <param name="firstPointZCoordinate">First point's applicate.</param>
        /// <param name="secondPointXCoordinate">Second point's abscissa.</param>
        /// <param name="secondPointYCoordinate">Second point's ordinate.</param>
        /// <param name="secondPointZCoordinate">Second point's applicate.</param>
        /// <returns>The distance between the points.</returns>
        /// <exception cref="OverflowException">Thrown when the calculations cannot be hold in <see cref="double"/> variable.</exception>
        public static double CalculateDistance3D(
            double firstPointXCoordinate,
            double firstPointYCoordinate,
            double firstPointZCoordinate,
            double secondPointXCoordinate = OriginXCoordinate,
            double secondPointYCoordinate = OriginYCoordinate,
            double secondPointZCoordinate = OriginZCoordinate)
        {
            double distance = CalculateDistanceByCoordinates(
                firstPointXCoordinate,
                firstPointYCoordinate,
                firstPointZCoordinate,
                secondPointXCoordinate,
                secondPointYCoordinate,
                secondPointZCoordinate);

            return distance;
        }

        /// <summary>
        /// Calculate distance between two points in 3D space by given coordinates.
        /// </summary>
        /// <param name="firstPointXCoordinate">First point's abscissa.</param>
        /// <param name="firstPointYCoordinate">First point's ordinate.</param>
        /// <param name="firstPointZCoordinate">First point's applicate.</param>
        /// <param name="secondPointXCoordinate">Second point's abscissa.</param>
        /// <param name="secondPointYCoordinate">Second point's ordinate.</param>
        /// <param name="secondPointZCoordinate">Second point's applicate.</param>
        /// <returns>The distance between the points.</returns>
        /// <exception cref="OverflowException">Thrown when the calculations cannot be hold in <see cref="double"/> variable.</exception>
        private static double CalculateDistanceByCoordinates(
            double firstPointXCoordinate,
            double firstPointYCoordinate,
            double firstPointZCoordinate,
            double secondPointXCoordinate = OriginXCoordinate,
            double secondPointYCoordinate = OriginYCoordinate,
            double secondPointZCoordinate = OriginZCoordinate)
        {
            double quadraticXProection = (secondPointXCoordinate - firstPointXCoordinate) * (secondPointXCoordinate - firstPointXCoordinate);
            double quadraticYProection = (secondPointYCoordinate - firstPointYCoordinate) * (secondPointYCoordinate - firstPointYCoordinate);
            double quadraticZProection = (secondPointZCoordinate - firstPointZCoordinate) * (secondPointZCoordinate - firstPointZCoordinate);

            double quadraticProectionSum = quadraticXProection + quadraticYProection + quadraticZProection;

            if (double.IsInfinity(quadraticProectionSum))
            {
                throw new OverflowException("The points are very far from each other to calculte correctly the distance!");
            }

            double distance = Math.Sqrt(quadraticProectionSum);

            return distance;
        }
    }
}
