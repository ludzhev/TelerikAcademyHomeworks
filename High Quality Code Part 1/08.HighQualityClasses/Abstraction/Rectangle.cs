// <copyright file="Rectangle.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>
// <summary>Holds implementation of static class Mathematics.</summary>

using System;

namespace Abstraction
{
    /// <summary>
    /// Represent a rectangle with width and height.
    /// </summary>
    public class Rectangle : IFigure
    {
        /// <summary>
        /// Width of the <see cref="Rectangle"/> instance.
        /// </summary>
        private double width;

        /// <summary>
        /// Height of the <see cref="Rectangle"/> instance.
        /// </summary>
        private double height;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="width">The width of the <see cref="Rectangle"/> instance.</param>
        /// <param name="height">The height of the <see cref="Rectangle"/> instance.</param>
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets or sets the width of the <see cref="Rectangle"/> instance.
        /// </summary>
        /// <value>Width of the <see cref="Rectangle"/> instance.</value>
        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be positive number!");
                }

                this.width = value;
            }
        }

        /// <summary>
        /// Gets or sets the height of the <see cref="Rectangle"/> instance.
        /// </summary>
        /// <value>Height of the <see cref="Rectangle"/> instance.</value>
        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be positive number!");
                }

                this.height = value;
            }
        }

        /// <summary>
        /// Calculate the perimeter of the <see cref="Rectangle"/> instance.
        /// </summary>
        /// <returns>Calculated perimeter.</returns>
        public double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        /// <summary>
        /// Calculate the surface of the <see cref="Rectangle"/> instance.
        /// </summary>
        /// <returns>Calculated surface.</returns>
        public double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
