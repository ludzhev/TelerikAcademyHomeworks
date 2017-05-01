// <copyright file="Cuboid.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>
// <summary>Holds implementation of static class Mathematics.</summary>

namespace CohesionAndCoupling
{
    /// <summary>
    /// Represent a cuboid in 3D space.
    /// </summary>
    public class Cuboid
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cuboid"/> class.
        /// </summary>
        /// <param name="width">Width of the <see cref="Cuboid"/> instance.</param>
        /// <param name="height">Height of the <see cref="Cuboid"/> instance.</param>
        /// <param name="depth">Depth of the <see cref="Cuboid"/> instance.</param>
        public Cuboid(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        /// <summary>
        /// Gets or sets the width of the <see cref="Cuboid"/> instance.
        /// </summary>
        /// <value>Width of the <see cref="Cuboid"/> instance.</value>
        public double Width { get; set; }

        /// <summary>
        /// Gets or sets the height of the <see cref="Cuboid"/> instance.
        /// </summary>
        /// <value>Height of the <see cref="Cuboid"/> instance.</value>
        public double Height { get; set; }

        /// <summary>
        /// Gets or sets the depth of the <see cref="Cuboid"/> instance.
        /// </summary>
        /// <value>Depth of the <see cref="Cuboid"/> instance.</value>
        public double Depth { get; set; }

        /// <summary>
        /// Calculate the volume of the <see cref="Cuboid"/> instance.
        /// </summary>
        /// <returns>The calculated volume.</returns>
        public double CalculateVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        /// <summary>
        /// Calculate the distance of the <see cref="Cuboid"/> instance's space diagonal.
        /// </summary>
        /// <returns>The calculated distance.</returns>
        public double CalculateSpaceDiagonal()
        {
            double distance = Point3D.CalculateDistance3D(this.Width, this.Height, this.Depth);
            return distance;
        }

        /// <summary>
        /// Calculate the distance of the <see cref="Cuboid"/> instance's face diagonal.
        /// </summary>
        /// <returns>The calculated distance.</returns>
        public double CalculateFaceDiagonal()
        {
            double distance = Point2D.CalculateDistance2D(this.Width, this.Height);
            return distance;
        }

        /// <summary>
        /// Calculate the distance of the <see cref="Cuboid"/> instance's top diagonal.
        /// </summary>
        /// <returns>The calculated distance.</returns>
        public double CalculateTopDiagonal()
        {
            double distance = Point2D.CalculateDistance2D(this.Width, this.Depth);
            return distance;
        }

        /// <summary>
        /// Calculate the distance of the <see cref="Cuboid"/> instance's side diagonal.
        /// </summary>
        /// <returns>The calculated distance.</returns>
        public double CalculateSideDiagonal()
        {
            double distance = Point2D.CalculateDistance2D(this.Height, this.Depth);
            return distance;
        }
    }
}
