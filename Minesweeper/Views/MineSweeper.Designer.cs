namespace CST227_Minesweeper.Views
{
    partial class MineSweeper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MineSweeper));
            this.btnQuitGame = new System.Windows.Forms.Button();
            this.lblPlayTime = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuitGame
            // 
            this.btnQuitGame.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuitGame.BackgroundImage")));
            this.btnQuitGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuitGame.FlatAppearance.BorderSize = 0;
            this.btnQuitGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuitGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuitGame.Location = new System.Drawing.Point(277, 9);
            this.btnQuitGame.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuitGame.Name = "btnQuitGame";
            this.btnQuitGame.Size = new System.Drawing.Size(25, 25);
            this.btnQuitGame.TabIndex = 0;
            this.btnQuitGame.UseVisualStyleBackColor = false;
            this.btnQuitGame.Click += new System.EventHandler(this.btnQuitGame_Click);
            // 
            // lblPlayTime
            // 
            this.lblPlayTime.AutoSize = true;
            this.lblPlayTime.BackColor = System.Drawing.Color.Black;
            this.lblPlayTime.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlayTime.Location = new System.Drawing.Point(56, 9);
            this.lblPlayTime.Name = "lblPlayTime";
            this.lblPlayTime.Size = new System.Drawing.Size(71, 40);
            this.lblPlayTime.TabIndex = 1;
            this.lblPlayTime.Text = "TIME\r\n00:00:00";
            this.lblPlayTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Black;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblScore.Location = new System.Drawing.Point(184, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(59, 40);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "SCORE\r\n0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MineSweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(311, 202);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblPlayTime);
            this.Controls.Add(this.btnQuitGame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MineSweeper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MineSweeper";
            this.TransparencyKey = System.Drawing.Color.DarkSeaGreen;
            this.Load += new System.EventHandler(this.MineSweeper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitGame;
        public System.Windows.Forms.Label lblPlayTime;
        public System.Windows.Forms.Label lblScore;
    }
}