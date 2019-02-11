using CST227_Minesweeper.Models;
using CST227_Minesweeper.Views.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST227_Minesweeper.Models
{
    class Grid
    {
        public Switch[,] Minefield { get; set; }
        public int Size { get; set; }

        public Grid(int size)
        {
            Size = size;
            Minefield = new Switch[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Minefield[i, j] = new Switch(i, j);
                }
            }
        }

        public virtual int ActivateRandomCells(double percentage)
        {
            Random random = new Random();
            int totalLiveCount = 0;

            if (percentage > 100 || percentage < 1)
            {
                percentage = 1;
            } else
            {
                percentage = (int)Math.Round((Size * Size) * (percentage / 100.00));
                totalLiveCount = (int)percentage;
            }

            while (percentage > 0)
            {
                var cell = Minefield[
                    random.Next(0, Size),
                    random.Next(0, Size)];

                if (cell.Live == false)
                {
                    cell.Live = true;
                    percentage -= 1;
                }
                else
                {
                    continue;
                }
            }

            SetLiveCount();
            return totalLiveCount;
        }

        public virtual void SetLiveCount()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {

                    // Check North
                    if (i - 1 >= 0)
                    {
                        if (Minefield[i - 1, j].Live == true)
                        {
                            Minefield[i, j].LiveNeighbors += 1;
                        }
                    }

                    // Check South
                    if (i + 1 < Size)
                    {
                        if (Minefield[i + 1, j].Live == true)
                        {
                            Minefield[i, j].LiveNeighbors += 1;
                        }
                    }

                    // Check East
                    if (j + 1 < Size)
                    {
                        if (Minefield[i, j + 1].Live == true)
                        {
                            Minefield[i, j].LiveNeighbors += 1;
                        }
                    }

                    // Check West
                    if (j - 1 >= 0)
                    {
                        if (Minefield[i, j - 1].Live == true)
                        {
                            Minefield[i, j].LiveNeighbors += 1;
                        }
                    }
                }
            }
        }

        public virtual void RevealGrid()
        {
            // Clears the console before printing.
            Console.Clear();

            // Print overall color of the map in white.
            Console.ForegroundColor = ConsoleColor.White;

            var title = "M I N E S W E E P E R".PadLeft(Size * 4 - 7, ' ');

            Console.WriteLine(title + Environment.NewLine);

            Console.Write("    |");

            for (int i = 0; i < Size; i++)
            {
                Console.Write(" " + i + " |");
            }

            Console.WriteLine();

            for (int i = 0; i < Size; i++)
            {
                Console.Write("| " + i + " |");
                for (int j = 0; j < Size; j++)
                {
                    var location = Minefield[i, j];

                    if (Minefield[i, j].Live == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" *");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" |");
                    }
                    else
                    {
                        if (Minefield[i, j].LiveNeighbors == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" ~");
                        }
                        else if (Minefield[i, j].LiveNeighbors >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(" " + Minefield[i, j].LiveNeighbors);
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" |");
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Resets all cells.
        /// </summary>
        public void ResetCells()
        {
            foreach (Switch s in Minefield)
            {
                s.Reset(s.Row, s.Column);
            }
        }
    }
}
