// <copyright file="FiguresExample.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>
// <summary>Holds implementation of static class Mathematics.</summary>

using System;

namespace Abstraction
{
    /// <summary>
    /// Represent example application with figures.
    /// </summary>
    public class FiguresExample
    {
        /// <summary>
        /// Represent the starting point of the examples.
        /// </summary>
        public static void Main()
        {
            Circle circle = new Circle(5);
            Console.WriteLine("I am a circle. My perimeter is {0:f2}. My surface is {1:f2}.", circle.CalculatePerimeter(), circle.CalculateSurface());

            Rectangle rect = new Rectangle(2, 3);
            Console.WriteLine("I am a rectangle. My perimeter is {0:f2}. My surface is {1:f2}.", rect.CalculatePerimeter(), rect.CalculateSurface());
        }
    }
}
