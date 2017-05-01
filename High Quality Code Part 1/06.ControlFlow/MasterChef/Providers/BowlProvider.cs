// <copyright file="BowlProvider.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>

using MasterChef.KitchenWare;

namespace MasterChef.Providers
{
    /// <summary>
    /// <see cref="Bowl" /> instances generator.
    /// </summary>
    public class BowlProvider
    {
        /// <summary>
        /// Generate new <see cref="Bowl" /> instance and return it.
        /// </summary>
        /// <returns>new <see cref="Bowl" /> instance</returns>
        public Bowl GetBowl()
        {
            return new Bowl();
        }
    }
}