using MilestoneFour.Controllers;
using System;

using System.Windows.Forms;

namespace MilestoneFour.Views
{
    /// <summary>
    /// Input Dialog class.
    /// </summary>
    /// 
    /// <remarks>
    /// Descr.:     Allows player to input name is they scored in the top ten
    /// 
    /// Author:     Jay Wilson
    /// Date:       02/03/19
    /// Version:    1.0
    /// </remarks>
    public partial class InputDialog : Form
    {
        public PlayerDataController playerData;

        private FileController fileController;

        private int score;
        private int modifier;

        private Timer timer;

        public InputDialog(PlayerDataController playerData)
        {
            InitializeComponent();

            this.playerData = playerData;

            score = 0;

            if (playerData.Player.Score == 0)
            {
                lblScore.Text = playerData.Player.Score.ToString();
            }
            else
            {
                timer = new Timer();
                timer.Interval = 1;
                timer.Tick += new EventHandler(timer_Tick);
                timer.Enabled = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            playerData.Player.Name = txtUsername.Text.Trim();

            Dispose();

        }


        /// <summary>
        /// Timer Event.
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {
            score += (1 + modifier);

            lblScore.Text = score.ToString();

            if (score >= playerData.Player.Score)
            {
                lblScore.Text = playerData.Player.Score.ToString();
                timer.Enabled = false;
            }

            modifier += 5;
        }

        private void InputDialog_Load(object sender, EventArgs e)
        {
            Location = new System.Drawing.Point(
                (Screen.FromControl(this).Bounds.Width / 2) - (this.Width / 2),
                (Screen.FromControl(this).Bounds.Height / 2) - (this.Height / 2));

        }
    }
}
