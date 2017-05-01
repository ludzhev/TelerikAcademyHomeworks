// <copyright file="IFigure.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>
// <summary>Holds implementation of static class Mathematics.</summary>

namespace Abstraction
{
    /// <summary>
    /// Defines methods to calculate perimeter and surface of the <see cref="IFigure"/> heir.
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Calculate the perimeter of the <see cref="IFigure"/> heir.
        /// </summary>
        /// <returns>Calculated perimeter.</returns>
        double CalculatePerimeter();

        /// <summary>
        /// Calculate the surface of the <see cref="IFigure"/> heir.
        /// </summary>
        /// <returns>Calculated surface.</returns>
        double CalculateSurface();
    }
}
