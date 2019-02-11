using MilestoneFour.Controllers;
using MilestoneFour.Models;
using System;
using System.Text;
using System.Windows.Forms;

namespace MilestoneFour.Views
{
    /// <summary>
    /// frmHighScore class.
    /// </summary>
    /// 
    /// <remarks>
    /// Descr.:     The HighScore form view.
    /// 
    /// Author:     Jay Wilson
    /// Date:       01/31/19
    /// Version:    1.0
    /// </remarks>
    public partial class frmHighScore : Form
    {
        public frmHighScore()
        {
            InitializeComponent();

            // Declare and initialize FileControllerController
            FileController fileController = new FileController();

            TimeSpan time;

            foreach (PlayerData data in fileController.Data)
            {
                time = TimeSpan.FromSeconds(data.TimeInSeconds);

                string[] row =
                {
                    data.Name,
                    data.Score.ToString(),
                    time.ToString(@"hh\:mm\:ss")
                };

                var score = new ListViewItem(row);

                lvScores.Items.Add(score);

                //scores.Append(data.Name + "     " + data.Score + "     " + time.ToString(@"hh\:mm\:ss") + Environment.NewLine);
            }
        }

        private void label1_Click(object sender, System.EventArgs e)
        {
            // Do nothing
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmHighScore_Load(object sender, EventArgs e)
        {
            Location = new System.Drawing.Point(
                (Screen.FromControl(this).Bounds.Width / 2) - (this.Width / 2),
                (Screen.FromControl(this).Bounds.Height / 2) - (this.Height / 2));
        }
    }
}
