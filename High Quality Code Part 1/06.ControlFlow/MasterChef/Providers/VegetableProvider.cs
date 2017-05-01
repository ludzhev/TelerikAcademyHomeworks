// <copyright file="VegetableProvider.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>

using MasterChef.Vegetables;

namespace MasterChef.Providers
{
    /// <summary>
    /// <see cref="Vegetable" /> instances generator.
    /// </summary>
    public class VegetableProvider
    {
        /// <summary>
        /// Generate new <see cref="Carrot" /> instance and return it.
        /// </summary>
        /// <returns>new <see cref="Carrot" /> instance</returns>
        public Carrot GetCarrot()
        {
            return new Carrot();
        }

        /// <summary>
        /// Generate new <see cref="Potato" /> instance and return it.
        /// </summary>
        /// <returns>new <see cref="Potato" /> instance</returns>
        public Potato GetPotato()
        {
            return new Potato();
        }
    }
}