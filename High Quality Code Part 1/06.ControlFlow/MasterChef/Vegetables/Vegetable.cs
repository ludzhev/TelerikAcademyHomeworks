// <copyright file="Vegetable.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>

using System;
using MasterChef.Contracts;

namespace MasterChef.Vegetables
{
    /// <summary>
    /// Represent a vegetable.
    /// </summary>
    public class Vegetable : IEatable
    {
        /// <summary>
        /// Hold state if the instance is cut.
        /// </summary>
        private bool isCut;

        /// <summary>
        /// Hold state if the instance is pealed.
        /// </summary>
        private bool isPeeled;

        /// <summary>
        /// Hold state if the instance is rotten.
        /// </summary>
        private bool isRotten;

        /// <summary>
        /// Initializes a new instance of the <see cref="Vegetable" /> class.
        /// </summary>
        /// <param name="isCut">Set rather new instance is cut or not.</param>
        /// <param name="isPeeled">Set rather new instance is peeled or not.</param>
        /// <param name="isRotten">Set rather new instance is rotten or not.</param>
        public Vegetable(bool isCut = false, bool isPeeled = false, bool isRotten = false)
        {
            this.IsCut = isCut;
            this.IsPeeled = isPeeled;
            this.IsRotten = isRotten;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the instance is cut or not.
        /// </summary>
        public bool IsCut
        {
            get
            {
                return this.isCut;
            }

            set
            {
                if (value == false && this.isCut)
                {
                    throw new ArgumentException("Cannot uncut a vegetable!");
                }

                this.isCut = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the instance is peeled or not.
        /// </summary>
        public bool IsPeeled
        {
            get
            {
                return this.isPeeled;
            }

            set
            {
                if (value == false && this.isPeeled)
                {
                    throw new ArgumentException("Cannot unpeeled a vegetable!");
                }

                this.isPeeled = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the instance is rotten or not.
        /// </summary>
        public bool IsRotten
        {
            get
            {
                return this.isRotten;
            }

            set
            {
                if (value == false && this.isRotten)
                {
                    throw new ArgumentException("Cannot fresh-up a vegetable!");
                }

                this.isRotten = value;
            }
        }
    }
}