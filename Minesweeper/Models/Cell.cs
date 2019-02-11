namespace CST227_Minesweeper.Models
{
    /// <summary>
    /// Cell class.
    /// </summary>
    /// 
    /// <remarks>
    /// Descr.:     The cell class for the grid.
    /// 
    /// Author:     Jay Wilson
    /// Date:       01/27/19
    /// Version:    1.0
    /// </remarks>

    class Cell
    {
        // Class members
        public double Row { get; set; }
        public double Column { get; set; }
        public bool Visited { get; set; }
        public bool Live { get; set; }
        public double LiveNeighbors { get; set; }

        /// <summary>
        /// Constructor for game cells.
        /// </summary>
        /// <param name="row">Row location of cell. Initial value -1.</param>
        /// <param name="column">Column location of cell. Initial value -1.</param>
        public Cell(double row = -1, double column = -1)
        {
            Reset(row, column);
        }

        /// <summary>
        /// Reset cell.
        /// </summary>
        public void Reset(double row, double column)
        {
            Row = row;
            Column = column;
            Visited = false;
            Live = false;
            LiveNeighbors = 0;
        }
    }
}
