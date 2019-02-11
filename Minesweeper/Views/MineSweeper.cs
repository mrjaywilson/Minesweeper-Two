using CST227_Minesweeper.Controllers;
using System;
using System.Windows.Forms;

namespace CST227_Minesweeper.Views
{
    /// <summary>
    /// MineSweeper class.
    /// </summary>
    /// 
    /// <remarks>
    /// Descr.:     The MineSweeper class form view.
    /// 
    /// Author:     Jay Wilson
    /// Date:       01/27/19
    /// Version:    1.0
    /// </remarks>

    public partial class MineSweeper : Form
    {
        // GameController
        GameController gameController;

        TimeSpan time;

        /// <summary>
        /// Minesweeper Constructor
        /// </summary>
        /// <param name="difficulty">The difficulty of the game.</param>
        /// <param name="bar">Reference to progress bar.</param>
        public MineSweeper(int difficulty, ProgressBar bar)
        {
            // Initialization
            InitializeComponent();

            // Switch varies by difficulty
            switch (difficulty)
            {
                // Sets the game to Easy
                case 1:
                    gameController = new GameController(5, bar, this);
                    this.Width = 9 * 25;
                    this.Height = 9 * 25;

                    bar.Maximum = (int)Math.Pow(5, 2);

                    btnQuitGame.Location = new System.Drawing.Point(this.Width - btnQuitGame.Width - 10, 10);
                    break;

                // Sets the game to Medium
                case 2:
                    gameController = new GameController(8, bar, this);
                    this.Width = 12 * 25;
                    this.Height = 12 * 25;

                    bar.Maximum = (int)Math.Pow(8, 2);

                    btnQuitGame.Location = new System.Drawing.Point(this.Width - btnQuitGame.Width - 15, 15);
                    break;

                // Sets the game to Hard
                case 3:
                    gameController = new GameController(10, bar, this);
                    this.Width = 14 * 25;
                    this.Height = 14 * 25;

                    bar.Maximum = (int)Math.Pow(10, 2);

                    btnQuitGame.Location = new System.Drawing.Point(this.Width - btnQuitGame.Width - 20, 20);
                    break;

                // Sets the game to Nightmare
                case 4:
                    gameController = new GameController(16, bar, this);
                    this.Width = 20 * 25;
                    this.Height = 20 * 25;

                    bar.Maximum = (int)Math.Pow(16, 2);

                    btnQuitGame.Location = new System.Drawing.Point(this.Width - btnQuitGame.Width - 20, 20);
                    break;
            }

            // Label location for the timer.
            lblPlayTime.Location = new System.Drawing.Point((this.Width / 3) - (lblPlayTime.Width / 2), 10);

            // Set up timer for the game timer.
            gameController.timer.Interval = 1000;
            gameController.timer.Tick += new EventHandler(timer_Tick);
            gameController.timer.Enabled = true;

            // Label for score
            lblScore.Location = new System.Drawing.Point((Width - (Width / 3) - lblScore.Width / 2), 10);
        }

        /// <summary>
        /// Timer Event.
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {
            // Increment 'seconds' by 1
            gameController.playTimer += 1;

            // Convert time
            time = TimeSpan.FromSeconds(gameController.playTimer);

            // Output value to label
            lblPlayTime.Text = "TIME\n" + time.ToString(@"hh\:mm\:ss");
        }

        /// <summary>
        /// The load method for the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MineSweeper_Load(object sender, System.EventArgs e)
        {
            // Creat the gameboard
            Panel grid = gameController.PaintBoard();

            // Add the gameboard to the form
            Controls.Add(grid);

            // Accurately Center Form on Screen
            StartPosition = FormStartPosition.Manual;

            Location = new System.Drawing.Point(
                (Screen.FromControl(this).Bounds.Width / 2) - (this.Width / 2), 
                (Screen.FromControl(this).Bounds.Height / 2) - (this.Height / 2));
        }

        /// <summary>
        /// Method for button to quit the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitGame_Click(object sender, System.EventArgs e)
        {
            // Exit the playfield
            frmSplash form = new frmSplash();
            form.Show();
            Dispose();
        }
    }
}
