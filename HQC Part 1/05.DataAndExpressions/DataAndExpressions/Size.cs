// <copyright file="Size.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>

using System;

namespace DataAndExpressions
{
    /// <summary>
    /// Represent a two-dimensional size measurement.
    /// </summary>
    public class Size
    {
        /// <summary>
        /// Represent the width of the Size.
        /// </summary>
        private double width;

        /// <summary>
        /// Represent the height of the Size.
        /// </summary>
        private double height;

        /// <summary>
        /// Initializes a new instance of the <see cref="Size" /> class.
        /// </summary>
        /// <param name="width">The width of the Size.</param>
        /// <param name="height">The height of the Size.</param>
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets the width of the Size.
        /// </summary>
        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be negative number!");
                }

                this.width = value;
            }
        }

        /// <summary>
        /// Gets the height of the Size.
        /// </summary>
        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be negative number!");
                }

                this.height = value;
            }
        }

        /// <summary>
        ///    Get Size rotated by a given angle. 
        /// </summary>
        /// <param name="origin">The Size witch will be rotated.</param>
        /// <param name="angle">The angle by witch the size will be rotated.</param>
        /// <returns>Return a new Size, rotated by a given angle. </returns>
        public static Size GetRotatedSize(Size origin, double angle)
        {
            double rotatedWidth = (Math.Abs(Math.Cos(angle)) * origin.Width) + (Math.Abs(Math.Sin(angle)) * origin.Height);
            double rotatedHeight = (Math.Abs(Math.Sin(angle)) * origin.Width) + (Math.Abs(Math.Cos(angle)) * origin.Height);

            return new Size(rotatedWidth, rotatedHeight);
        }
    }
}
