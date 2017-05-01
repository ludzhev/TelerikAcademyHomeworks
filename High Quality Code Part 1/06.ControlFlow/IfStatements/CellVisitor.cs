// <copyright file="CellVisitor.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>

namespace IfStatements
{
    /// <summary>
    /// Represent a cell visitor presenting methods to visit a <see cref="Cell{T}"/> instance in given conditions.
    /// </summary>
    /// <typeparam name="T">The value of the <see cref="Cell{T}"/> instances. </typeparam>
    public class CellVisitor<T>
    {
        /// <summary>
        /// Visit a table by given row and column in a table, if the cell is not visited yet.
        /// </summary>
        /// <param name="row">Cell's row in the table.</param>
        /// <param name="column">Cell's column in the table.</param>
        /// <param name="table">The table of cells.</param>
        public void VisitCellInTable(int row, int column, CellTable<T> table)
        {
            bool isRowInRange = 0 <= row && row < table.Cells.GetLength(0);
            bool isColumnInRTange = 0 <= column && column < table.Cells.GetLength(1);

            if (isRowInRange && isColumnInRTange && !table.Cells[row, column].IsVisited)
            {
                table.Cells[row, column].IsVisited = true;
            }
        }
    }
}
