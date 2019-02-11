using CST227_Minesweeper.Models;
using System.Drawing;
using System.Windows.Forms;

namespace CST227_Minesweeper.Views.Controls
{
    class Switch : Button
    {
        // Class members
        public double Row { get; set; }
        public double Column { get; set; }
        public bool Visited { get; set; }
        public bool Live { get; set; }
        public double LiveNeighbors { get; set; }

        /// <summary>
        /// Constructor for cells.
        /// </summary>
        /// <param name="row">Row location of cell. Initial value -1.</param>
        /// <param name="column">Column location of cell. Initial value -1.</param>
        public Switch(double row = -1, double column = -1)
        {
            Reset(row, column);
            //            Row = row;
            //            Column = column;
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

        public void Reveal()
        {
            if (LiveNeighbors == 0)
            {
                ForeColor = Color.Green;
            }
            else if (LiveNeighbors == 1)
            {
                ForeColor = Color.GreenYellow;
            }
            else if (LiveNeighbors == 2)
            {
                ForeColor = Color.Yellow;
            }
            else if (LiveNeighbors == 3)
            {
                ForeColor = Color.Orange;
            }
            else if (LiveNeighbors == 4)
            {
                ForeColor = Color.OrangeRed;
            }

            Text = LiveNeighbors.ToString();
        }

    }
}
