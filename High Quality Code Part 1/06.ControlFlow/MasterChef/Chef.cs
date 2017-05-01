// <copyright file="Chef.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>

using System;

using MasterChef.KitchenWare;
using MasterChef.Providers;
using MasterChef.Vegetables;

namespace MasterChef
{
    /// <summary>
    /// Represent a Chef that can cook.
    /// </summary>
    public class Chef
    {
        /// <summary>
        /// Represent <see cref="Bowl"/> instances provider.
        /// </summary>
        private readonly BowlProvider bowlProvider;

        /// <summary>
        /// Represent <see cref="Vegetable"/> instances provider.
        /// </summary>
        private readonly VegetableProvider vegetableProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="Chef" /> class.
        /// </summary>
        /// <param name="bowlProvider"><see cref="Bowl"/> instances provider.</param>
        /// <param name="vegetableProvider"><see cref="Vegetable"/> instances provider.</param>
        public Chef(BowlProvider bowlProvider, VegetableProvider vegetableProvider)
        {
            if (bowlProvider == null)
            {
                throw new ArgumentNullException(nameof(bowlProvider), "BowlProvider cannot be null!");
            }

            if (vegetableProvider == null)
            {
                throw new ArgumentNullException(nameof(vegetableProvider), "VegetableProvider cannot be null!");
            }

            this.bowlProvider = bowlProvider;
            this.vegetableProvider = vegetableProvider;
        }
        
        /// <summary>
        /// Cook dishes.
        /// </summary>
        public void Cook()
        {
            Bowl currentBowl = this.bowlProvider.GetBowl();

            Potato currentPotato = this.vegetableProvider.GetPotato();
            this.Peel(currentPotato);
            this.Cut(currentPotato);

            // Logic from task 2
            if (currentPotato.IsPeeled && !currentPotato.IsRotten)
            {
                currentBowl.Add(currentPotato);
            }

            Carrot currentCarrot = this.vegetableProvider.GetCarrot();
            this.Peel(currentCarrot);
            this.Cut(currentCarrot);
            currentBowl.Add(currentCarrot);
        }

        /// <summary>
        /// Cut a <see cref="Vegetable"/> instance.
        /// </summary>
        /// <param name="vegetable"><see cref="Vegetable"/> instance to be cut.</param>
        private void Cut(Vegetable vegetable)
        {
            vegetable.IsCut = true;
        }

        /// <summary>
        /// Peel a <see cref="Vegetable"/> instance.
        /// </summary>
        /// <param name="vegetable"><see cref="Vegetable"/> instance to be peeled.</param>
        private void Peel(Vegetable vegetable)
        {
            vegetable.IsPeeled = true;
        }
    }
}
