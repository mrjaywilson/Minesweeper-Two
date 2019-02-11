using System;
using System.Windows.Forms;
using CST227_Minesweeper.Controllers;
using MilestoneFour.Views;

namespace CST227_Minesweeper
{
    /// <summary>
    /// frmSplash class.
    /// </summary>
    /// 
    /// <remarks>
    /// Descr.:     The Splash screen class.
    /// 
    /// Author:     Jay Wilson
    /// Date:       01/20/19
    /// Version:    1.0
    /// </remarks>

    public partial class frmSplash : Form
    {
        // Minesweeper object
        private SplashController controller;

        /// <summary>
        /// Constructor
        /// </summary>
        public frmSplash()
        {
            // Initialization
            InitializeComponent();

            // Create Instance of Controller Class
            controller = new SplashController(pbLoading, this);

            // Setup the button events
            btnEasy.Click += new EventHandler(controller.Difficulty_Click);
            btnMedium.Click += new EventHandler(controller.Difficulty_Click);
            btnHard.Click += new EventHandler(controller.Difficulty_Click);
            btnNightmare.Click += new EventHandler(controller.Difficulty_Click);

            // Accurately Center Form on Screen
            this.StartPosition = FormStartPosition.Manual;

            this.Location = new System.Drawing.Point(
                (Screen.FromControl(this).Bounds.Width / 2) - (this.Width / 2),
                (Screen.FromControl(this).Bounds.Height / 2) - (this.Height / 2));
        }

        /// <summary>
        /// Events to exit the game.
        /// </summary>
        private void btnSplashQuit_MouseDown(object sender, MouseEventArgs e)
        {
            // Set the mouse down image for the exit down button
            //btnSplashQuit.BackgroundImage = 
        }

        private void btnSplashQuit_MouseUp(object sender, MouseEventArgs e)
        {
            // Set the mouse up image for the exit up button
            //btnSplashQuit.BackgroundImage = CST227_Minesweeper.Properties.Resources.exit_up;
        }

        private void btnSplashQuit_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        /// <summary>
        /// "Easter Egg" method to show high scores without having to play the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblSplashTitle_Click(object sender, EventArgs e)
        {
            frmHighScore highScore = new frmHighScore();

            highScore.ShowDialog();
        }
    }
}
