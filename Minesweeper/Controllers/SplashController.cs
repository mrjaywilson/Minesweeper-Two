using CST227_Minesweeper.Models;
using CST227_Minesweeper.Views;
using System;
using System.Windows.Forms;

namespace CST227_Minesweeper.Controllers
{
    /// <summary>
    /// SplashController class.
    /// </summary>
    /// 
    /// <remarks>
    /// Descr.:     The splashController class ties the views and the models together.
    /// 
    /// Author:     Jay Wilson
    /// Date:       01/27/19
    /// Version:    1.0
    /// </remarks>

    class SplashController : IPlayable
    {
        // Class level variables
        private MineSweeper game;
        private ProgressBar progressBar;
        private Form splash;

        public SplashController(ProgressBar progressBar, Form splash)
        {
            // Set the variables
            this.progressBar = progressBar;
            this.splash = splash;
        }

        // Difficulty button event
        public void Difficulty_Click(object sender, EventArgs e)
        {
            // Get the name of the sender object
            String name = ((Button)sender).Name;

            // Make progress bar visible
            progressBar.Visible = true;

            // Setup the game
            switch (name)
            {
                case "btnEasy":
                    game = new MineSweeper(1, progressBar);
                    break;
                case "btnMedium":
                    game = new MineSweeper(2, progressBar);
                    break;
                case "btnHard":
                    game = new MineSweeper(3, progressBar);
                    break;
                case "btnNightmare":
                    game = new MineSweeper(4, progressBar);
                    break;
            }

            PlayGame();
        }

        /// <summary>
        /// Play the game.
        /// </summary>
        public void PlayGame()
        {
            // Handle the game
            game.Show();
            splash.Hide();
        }
    }
}
