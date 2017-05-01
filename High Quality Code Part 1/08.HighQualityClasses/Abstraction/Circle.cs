// <copyright file="Circle.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>
// <summary>Holds implementation of static class Mathematics.</summary>

using System;

namespace Abstraction
{
    /// <summary>
    /// Represent a circle with radius.
    /// </summary>
    public class Circle : IFigure
    {
        /// <summary>
        /// Radius of the <see cref="Circle"/> instance.
        /// </summary>
        private double radius;

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">The radius of the <see cref="Circle"/> instance.</param>
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Gets or sets the radius of the <see cref="Circle"/> instance.
        /// </summary>
        /// <value>Radius of the <see cref="Circle"/> instance.</value>
        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius must be positive number!");
                }

                this.radius = value;
            }
        }

        /// <summary>
        /// Calculate the perimeter of the <see cref="Circle"/> instance.
        /// </summary>
        /// <returns>Calculated perimeter.</returns>
        public double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        /// <summary>
        /// Calculate the surface of the <see cref="Circle"/> instance.
        /// </summary>
        /// <returns>Calculated surface.</returns>
        public double CalculateSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
