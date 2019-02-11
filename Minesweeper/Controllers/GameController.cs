using CST227_Minesweeper.Views;
using CST227_Minesweeper.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using CST227_Minesweeper.Views.Controls;
using MilestoneFour.Controllers;
using MilestoneFour.Views;

namespace CST227_Minesweeper.Controllers
{
    /// <summary>
    /// GameController class.
    /// </summary>
    /// 
    /// <remarks>
    /// Descr.:     The the gamecontroller class to tie the views and the models together.
    /// 
    /// Author:     Jay Wilson
    /// Date:       01/27/19
    /// Version:    1.0
    /// </remarks>

    class GameController : Grid
    {
        public Timer timer { get; set; }
        public int playTimer { get; set; }

        // Size variable
        //int size;
        int Difficulty;
        int liveCount = 0;
        int visitedCount = 0;

        // Minesweeper object
        private MineSweeper game;

        // Progress bar object
        ProgressBar bar;
        private Panel gamePanel;
        private Switch[,] switches;
        private Cell[,] minefield;
        private MineSweeper gameForm;

        private PlayerDataController playerDataController;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="size">The Size of the grid.</param>
        /// <param name="bar">Reference to the progress bar control</param>
        public GameController(int size, ProgressBar bar, MineSweeper gameForm) :
            base(size)
        {
            // Game Properties
            // this.size = size;
            this.bar = bar;
            this.gameForm = gameForm;

            playTimer = 0;
            timer = new Timer();

            switches = new Switch[Size, Size];

            // Activate Random Cells
            liveCount = ActivateRandomCells(20);

            // Initialize PlayerDataController
            playerDataController = new PlayerDataController();
        }

        /// <summary>
        /// Activate random cells.
        /// </summary>
        /// <param name="percentage"></param>
        /// <returns></returns>
        public override int ActivateRandomCells(double percentage)
        {
            // Random object
            Random random = new Random();

            // Count of live items
            int totalLiveCount = 0;

            // Check of the percentage is within a range. (error handling)
            if (percentage > 100 || percentage < 1)
            {
                // If out of range, set to 15 percent (general rule)
                percentage = 15;
            }
            else
            {
                // Otherwise, set the percentage
                percentage = (int)Math.Round((Size * Size) * (percentage / 100.00));

                // set the number of bombs
                totalLiveCount = (int)percentage;
            }

            // Set random minefield locations to live
            while (percentage > 0)
            {
                var cell = this.Minefield[
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

            // Set the live count
            SetLiveCount();

            // Return the bomb count
            return totalLiveCount;
        }

        /// <summary>
        /// Creates the gameboard / grid
        /// </summary>
        public Panel PaintBoard()
        {
            gamePanel = new Panel();

            //switches = Minefield;

            for (int i = 0; i < Size; i++)
            {
                int locationY = i * 25;
                for (int j = 0; j < Size; j++)
                {
                    Switch gameSwitch = Minefield[i, j];
                    gameSwitch.Location = new Point(j * 25, locationY);
                    gameSwitch.Size = new Size(25, 25);

                    // Style Properties
                    gameSwitch.FlatStyle = FlatStyle.Flat;
                    gameSwitch.BackColor = Color.Black;
                    gameSwitch.ForeColor = Color.White;

                    // Progress bar properties handling
                    var value = bar.Value;
                    bar.Value = value;
                    bar.Value = value + 1;

                    gameSwitch.MouseDown += new MouseEventHandler(Switch_Click);

                    gamePanel.Controls.Add(gameSwitch);

                    // To handle stuff
                    switches[i, j] = gameSwitch;
                }
            }

            // Always load at specific location
            gamePanel.Location = new System.Drawing.Point(50, 50);
            gamePanel.Size = new System.Drawing.Size(Size * 26, Size * 26);

            // Style properties
            gamePanel.BackColor = Color.Black;

            // Return the game board
            return gamePanel;
        }

        /// <summary>
        /// Handle the board clicks.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Switch_Click(object sender, MouseEventArgs e)
        {
            Switch button = (Switch)sender;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (button.Live == true)
                    {
                        timer.Enabled = false;

                        TimeSpan time = TimeSpan.FromSeconds(playTimer);

                        playerDataController.Player.TimeInSeconds = playTimer;

                        string totalTimePlated = time.ToString(@"hh\:mm\:ss");

                        string gameCompleted = "You landed on a mine!\n\n Time Taken: " + totalTimePlated;

                        RevealMineField(1);

                        EndGame(gameCompleted);

                        timer.Enabled = false;
                    }
                    else
                    {
                        RevealSafeConnectingBlocks(button);

                        // Score based on time
                        if (playerDataController.Player.TimeInSeconds < 500)
                        {
                            playerDataController.Player.Score += 40;
                        }
                        else if (playerDataController.Player.TimeInSeconds < 2500)
                        {
                            playerDataController.Player.Score += 30;
                        }
                        else if (playerDataController.Player.TimeInSeconds < 3500)
                        {
                            playerDataController.Player.Score += 20;
                        }
                        else if (playerDataController.Player.TimeInSeconds < 4500)
                        {
                            playerDataController.Player.Score += 10;
                        }


                        UpdateScore();

                        CheckWin(button);
                    }
                    break;
                case MouseButtons.Right:

                    button.BackColor = Color.Black;
                    button.ForeColor = Color.White;
                    button.BackgroundImageLayout = ImageLayout.Stretch;

                    if (button.BackgroundImage != null)
                    {
                        button.BackgroundImage = null;
                        if (button.Live)
                        {
                        visitedCount -= 1;
                        }
                    } else
                    {
                        button.BackgroundImage = MilestoneFour.Properties.Resources.flag;

                        if (button.Live)
                        {
                            visitedCount += 1;
                        }

                    }

                    CheckWin(button);

                    break;
            }
        }

        private void UpdateScore()
        {
            gameForm.lblScore.Text = "SCORE\n" + playerDataController.Player.Score;
        }

        /// <summary>
        /// Method to end the game
        /// </summary>
        /// <param name="text"></param>
        private void EndGame(string text)
        {
            // Submit the score and get the index value for insertion into list
            int index = playerDataController.SubmitScore();

            // Check if the index is less than zero, if not, update records
            if (index >= 0)
            {
                // Show form and get name from form
                InputDialog input = new InputDialog(playerDataController);

                input.ShowDialog();

                // record player
                playerDataController.Record(index);
            }

            // Show High Scores
            frmHighScore highScore = new frmHighScore();
            highScore.ShowDialog();
        }

        /// <summary>
        /// Check if the player won
        /// </summary>
        /// <param name="button"></param>
        private bool CheckWin(Switch button)
        {
            // If the size of the board minues the live count is equal to the
            // visted count, the player won. Otherwise, nothing.
            if (Math.Pow(Size, 2) - liveCount == visitedCount)
            {
                timer.Enabled = false;

                TimeSpan time = TimeSpan.FromSeconds(playTimer);

                playerDataController.Player.TimeInSeconds = playTimer;

                string gameCompleted = "CONGRATS! YOU WIN!\n\n Time Taken: " + time.ToString(@"hh\:mm\:ss");

                RevealMineField(0);

                playerDataController.Player.TimeInSeconds = playTimer;

                EndGame(gameCompleted);

                return true;
            }

            return false;

        }

        /// <summary>
        /// Method to reveal the minefield
        /// </summary>
        /// <param name="status"></param>
        public void RevealMineField(int status)
        {

            int modifier = 0;

            if (status == 0)
            {
                modifier = 75;
            } else
            {
                modifier = 0;
            }

            // Iterate through the minefield
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {

                    // Set the image layout
                    switches[i, j].BackgroundImageLayout = ImageLayout.Stretch;

                    // If Live...
                    if (switches[i, j].Live == true)
                    {
                        switches[i, j].BackColor = Color.Transparent;

                        // If player won
                        if (status == 1)
                        {
                            // Show bomb
                            switches[i, j].BackgroundImage = MilestoneFour.Properties.Resources.bomb;
                            playerDataController.Player.Score += modifier;
                            UpdateScore();
                        }
                        else if (status == 0)
                        {
                            // Show flag
                            switches[i, j].BackgroundImage = MilestoneFour.Properties.Resources.flag;
                            playerDataController.Player.Score += (modifier + 25);
                            UpdateScore();
                        }
                    }
                    else
                    {
                        // Reveal location
                        switches[i, j].BackgroundImage = null;
                        switches[i, j].Reveal();
                        playerDataController.Player.Score += modifier;
                        UpdateScore();
                    }
                }
            }
        }

        /// <summary>
        /// Method to recursively check and visit adjoining cells
        /// that have no "live" neighbors, and to reveal
        /// any adjoining walls that are "live", but to go no
        /// further.
        /// </summary>
        public bool RevealSafeConnectingBlocks(Switch s)
        {
            s.Visited = true;
            s.Reveal();

            visitedCount += 1;

            if (s.LiveNeighbors > 0)
            {
                return false;
            }

            // Check to see if we are at outter bounds of entire map
            if (s.Column - 1 >= 0)
            {
                // Check the west location
                var westLocation = switches[(int)s.Row, (int)s.Column - 1];

                // If the location is not live or visited
                if (!westLocation.Live && !westLocation.Visited)
                {
                    // if the location has no live neighbors, keep going
                    if (westLocation.LiveNeighbors == 0)
                    {
                        // Recursively call method
                        RevealSafeConnectingBlocks(westLocation);
                    }
                    else
                    {
                        // Otherwise, mark as visited and
                        // increase visit count
                        westLocation.Visited = true;
                        westLocation.Reveal();
                        visitedCount += 1;
                        playerDataController.Player.Score += 10;
                        UpdateScore();
                    }
                }
            }

            // Check to see if we are at outter bounds of entire map
            if (s.Row - 1 >= 0)
            {
                // Check the north location
                var northLocation = switches[(int)s.Row - 1, (int)s.Column];

                // If the location is not live or visited
                if (!northLocation.Live && !northLocation.Visited)
                {
                    // if the location has no live neighbors, keep going
                    if (northLocation.LiveNeighbors == 0)
                    {
                        // Recursively call method
                        RevealSafeConnectingBlocks(northLocation);
                    }
                    else
                    {
                        // Otherwise, mark as visited and
                        // increase visit count
                        northLocation.Visited = true;
                        northLocation.Reveal();
                        visitedCount += 1;
                        playerDataController.Player.Score += 10;
                        UpdateScore();
                    }
                }
            }

            // Check to see if we are at outter bounds of entire map
            if (s.Column + 1 < Size)
            {
                // Check the south location
                var southLocation = switches[(int)s.Row, (int)s.Column + 1];

                // If the location is not live or visited
                if (!southLocation.Live && !southLocation.Visited)
                {
                    // if the location has no live neighbors, keep going
                    if (southLocation.LiveNeighbors == 0)
                    {
                        // Recursively call method
                        RevealSafeConnectingBlocks(southLocation);
                    }
                    else
                    {
                        // Otherwise, mark as visited and
                        // increase visit count
                        southLocation.Visited = true;
                        southLocation.Reveal();
                        visitedCount += 1;
                        playerDataController.Player.Score += 10;
                        UpdateScore();
                    }
                }
            }

            // Check to see if we are at outter bounds of entire map
            if (s.Row + 1 < Size)
            {
                // Check the east location
                var eastLocation = switches[(int)s.Row + 1, (int)s.Column];

                // If the location is not live or visited
                if (!eastLocation.Live && !eastLocation.Visited)
                {
                    // if the location has no live neighbors, keep going
                    if (eastLocation.LiveNeighbors == 0)
                    {
                        // Recursively call method
                        RevealSafeConnectingBlocks(eastLocation);
                    }
                    else
                    {
                        // Otherwise, mark as visited and
                        // increase visit count
                        eastLocation.Visited = true;
                        eastLocation.Reveal();
                        visitedCount += 1;
                        playerDataController.Player.Score += 10;
                        UpdateScore();
                    }
                }
            }

            // return false
            return false;

        }

        /// <summary>
        /// Temporary event the change the color of the buttons when clicked
        /// </summary>
        private void Test_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button != null)
            {
                button.BackColor = System.Drawing.Color.Blue;
            }
        }
    }
}
