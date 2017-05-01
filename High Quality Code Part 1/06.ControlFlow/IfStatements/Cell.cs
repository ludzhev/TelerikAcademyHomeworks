// <copyright file="Cell.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>

using System;

namespace IfStatements
{
    /// <summary>
    /// Represents a Cell with generic value.
    /// </summary>
    /// <typeparam name="T">The type of the value in the <see cref="Cell{T}" /> instance.</typeparam>
    public class Cell<T>
    {
        /// <summary>
        /// Hold the value of the <see cref="Cell{T}" /> instance. 
        /// </summary>
        private T value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cell{T}"/> class.
        /// </summary>
        /// <param name="value">The value of the new <see cref="Cell{T}"/> instance. </param>
        public Cell(T value)
        {
            this.Value = value;
            this.IsVisited = false;
        }

        /// <summary>
        /// Gets or sets a value of the <see cref="Cell{T}" /> instance.
        /// </summary>
        public T Value
        {
            get
            {
                return this.value;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Value cannot be null!");
                }

                this.value = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the instance is visited or not.
        /// </summary>
        public bool IsVisited { get; set; }
    }
}
