// <copyright file="CellTable.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>

using System;

namespace IfStatements
{
    /// <summary>
    /// Represent a two dimensional table of instances of the <see cref="Cell{T}"/> class.
    /// </summary>
    /// <typeparam name="T">The type of value of the <see cref="Cell{T}"/> instances.</typeparam>
    public class CellTable<T>
    {
        /// <summary>
        /// Holds the cells of the <see cref="CellTable{T}"/> instance.
        /// </summary>
        private Cell<T>[,] matrix;

        /// <summary>
        /// Initializes a new instance of the <see cref="CellTable{T}"/> class.
        /// </summary>
        /// <param name="cells">The initial cells of the <see cref="CellTable{T}"/> instance.</param>
        public CellTable(Cell<T>[,] cells)
        {
            this.Cells = cells;
        }

        /// <summary>
        /// Gets a cells of the table.
        /// </summary>
        public Cell<T>[,] Cells
        {
            get
            {
                // TODO: return copy if possible;
                return this.matrix;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Cells cannot be null!");
                }

                foreach (var cell in value)
                {
                    if (cell == null)
                    {
                        throw new ArgumentNullException(nameof(cell), "Each cell in cells cannot be null!");
                    }
                }

                this.matrix = value;
            }
        }
    }
}
