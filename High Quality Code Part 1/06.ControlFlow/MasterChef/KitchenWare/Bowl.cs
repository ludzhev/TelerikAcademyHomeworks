// <copyright file="Bowl.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>

using System;
using System.Collections.Generic;

using MasterChef.Contracts;

namespace MasterChef.KitchenWare
{
    /// <summary>
    /// Represent Bowl.
    /// </summary>
    public class Bowl
    {
        /// <summary>
        /// Collection that represent the content of the Bowl.
        /// </summary>
        private readonly ICollection<IEatable> content;

        /// <summary>
        /// Initializes a new instance of the <see cref="Bowl" /> class.
        /// </summary>
        public Bowl()
        {
            this.content = new List<IEatable>();
        }

        /// <summary>
        /// Gets the content's count.
        /// </summary>
        public int ContentCount => this.content.Count;

        /// <summary>
        /// Adds a <see cref="IEatable"/> heir to the content of the Bowl.
        /// </summary>
        /// <param name="food">Item to add.</param>
        public void Add(IEatable food)
        {
            if (food == null)
            {
                throw new ArgumentNullException(nameof(food), "Null cannot be added to Bowl!");
            }

            this.content.Add(food);
        }
    }
}