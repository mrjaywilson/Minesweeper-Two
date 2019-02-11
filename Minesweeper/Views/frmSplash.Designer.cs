namespace CST227_Minesweeper
{
    partial class frmSplash
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
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnNightmare = new System.Windows.Forms.Button();
            this.lblSplashTitle = new System.Windows.Forms.Label();
            this.btnSplashQuit = new System.Windows.Forms.Button();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.btnEasy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMedium
            // 
            this.btnMedium.BackColor = System.Drawing.Color.Black;
            this.btnMedium.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMedium.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMedium.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedium.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedium.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMedium.Location = new System.Drawing.Point(9, 177);
            this.btnMedium.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(207, 39);
            this.btnMedium.TabIndex = 1;
            this.btnMedium.Text = "I like a challenge.";
            this.btnMedium.UseVisualStyleBackColor = false;
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.Color.Black;
            this.btnHard.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnHard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHard.Location = new System.Drawing.Point(9, 222);
            this.btnHard.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(207, 38);
            this.btnHard.TabIndex = 2;
            this.btnHard.Text = "Go big or go home!";
            this.btnHard.UseVisualStyleBackColor = false;
            // 
            // btnNightmare
            // 
            this.btnNightmare.BackColor = System.Drawing.Color.Black;
            this.btnNightmare.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNightmare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnNightmare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnNightmare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNightmare.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNightmare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNightmare.Location = new System.Drawing.Point(9, 266);
            this.btnNightmare.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNightmare.Name = "btnNightmare";
            this.btnNightmare.Size = new System.Drawing.Size(207, 36);
            this.btnNightmare.TabIndex = 3;
            this.btnNightmare.Text = "Living nightmare!";
            this.btnNightmare.UseVisualStyleBackColor = false;
            // 
            // lblSplashTitle
            // 
            this.lblSplashTitle.AutoSize = true;
            this.lblSplashTitle.BackColor = System.Drawing.Color.Black;
            this.lblSplashTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplashTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSplashTitle.Location = new System.Drawing.Point(33, 29);
            this.lblSplashTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSplashTitle.Name = "lblSplashTitle";
            this.lblSplashTitle.Size = new System.Drawing.Size(155, 90);
            this.lblSplashTitle.TabIndex = 4;
            this.lblSplashTitle.Text = "CHOOSE YOUR\r\nMINESWEEPER\r\nDIFFICULTY";
            this.lblSplashTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSplashTitle.Click += new System.EventHandler(this.lblSplashTitle_Click);
            // 
            // btnSplashQuit
            // 
            this.btnSplashQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnSplashQuit.BackgroundImage = global::MilestoneFour.Properties.Resources.exit_up;
            this.btnSplashQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSplashQuit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSplashQuit.FlatAppearance.BorderSize = 0;
            this.btnSplashQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSplashQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSplashQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSplashQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplashQuit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSplashQuit.Location = new System.Drawing.Point(190, 10);
            this.btnSplashQuit.Margin = new System.Windows.Forms.Padding(0);
            this.btnSplashQuit.Name = "btnSplashQuit";
            this.btnSplashQuit.Size = new System.Drawing.Size(25, 25);
            this.btnSplashQuit.TabIndex = 6;
            this.btnSplashQuit.UseVisualStyleBackColor = false;
            this.btnSplashQuit.Click += new System.EventHandler(this.btnSplashQuit_Click);
            this.btnSplashQuit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSplashQuit_MouseDown);
            this.btnSplashQuit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSplashQuit_MouseUp);
            // 
            // pbLoading
            // 
            this.pbLoading.BackColor = System.Drawing.Color.Black;
            this.pbLoading.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pbLoading.Location = new System.Drawing.Point(27, 317);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(172, 10);
            this.pbLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbLoading.TabIndex = 7;
            this.pbLoading.Visible = false;
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.Black;
            this.btnEasy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEasy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEasy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEasy.Location = new System.Drawing.Point(9, 138);
            this.btnEasy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(207, 33);
            this.btnEasy.TabIndex = 0;
            this.btnEasy.Text = "Let\'s Take it easy...";
            this.btnEasy.UseVisualStyleBackColor = false;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = global::MilestoneFour.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(225, 355);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.btnSplashQuit);
            this.Controls.Add(this.lblSplashTitle);
            this.Controls.Add(this.btnNightmare);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnEasy);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MINESWEEPER";
            this.TransparencyKey = System.Drawing.Color.DarkSeaGreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnNightmare;
        private System.Windows.Forms.Label lblSplashTitle;
        private System.Windows.Forms.Button btnSplashQuit;
        public System.Windows.Forms.ProgressBar pbLoading;
        private System.Windows.Forms.Button btnEasy;
    }
}

