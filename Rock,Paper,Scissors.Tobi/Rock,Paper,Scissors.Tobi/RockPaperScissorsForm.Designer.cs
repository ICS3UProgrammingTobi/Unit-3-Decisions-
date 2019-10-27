namespace Rock_Paper_Scissors.Tobi
{
    partial class frmRockPaperScissors
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
            this.grbPlayer = new System.Windows.Forms.GroupBox();
            this.radPlayerScissors = new System.Windows.Forms.RadioButton();
            this.radPlayerPaper = new System.Windows.Forms.RadioButton();
            this.radPlayerRock = new System.Windows.Forms.RadioButton();
            this.grbComputer = new System.Windows.Forms.GroupBox();
            this.radComputerScissors = new System.Windows.Forms.RadioButton();
            this.radComputerPaper = new System.Windows.Forms.RadioButton();
            this.radComputerRock = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.grbPlayer.SuspendLayout();
            this.grbComputer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPlayer
            // 
            this.grbPlayer.Controls.Add(this.radPlayerScissors);
            this.grbPlayer.Controls.Add(this.radPlayerPaper);
            this.grbPlayer.Controls.Add(this.radPlayerRock);
            this.grbPlayer.Location = new System.Drawing.Point(48, 27);
            this.grbPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.grbPlayer.Name = "grbPlayer";
            this.grbPlayer.Padding = new System.Windows.Forms.Padding(4);
            this.grbPlayer.Size = new System.Drawing.Size(276, 203);
            this.grbPlayer.TabIndex = 0;
            this.grbPlayer.TabStop = false;
            this.grbPlayer.Text = "Player\'s Choice";
            // 
            // radPlayerScissors
            // 
            this.radPlayerScissors.AutoSize = true;
            this.radPlayerScissors.Location = new System.Drawing.Point(39, 159);
            this.radPlayerScissors.Margin = new System.Windows.Forms.Padding(4);
            this.radPlayerScissors.Name = "radPlayerScissors";
            this.radPlayerScissors.Size = new System.Drawing.Size(82, 21);
            this.radPlayerScissors.TabIndex = 2;
            this.radPlayerScissors.TabStop = true;
            this.radPlayerScissors.Text = "Scissors";
            this.radPlayerScissors.UseVisualStyleBackColor = true;
            // 
            // radPlayerPaper
            // 
            this.radPlayerPaper.AutoSize = true;
            this.radPlayerPaper.Location = new System.Drawing.Point(39, 110);
            this.radPlayerPaper.Margin = new System.Windows.Forms.Padding(4);
            this.radPlayerPaper.Name = "radPlayerPaper";
            this.radPlayerPaper.Size = new System.Drawing.Size(67, 21);
            this.radPlayerPaper.TabIndex = 1;
            this.radPlayerPaper.TabStop = true;
            this.radPlayerPaper.Text = "Paper";
            this.radPlayerPaper.UseVisualStyleBackColor = true;
            // 
            // radPlayerRock
            // 
            this.radPlayerRock.AutoSize = true;
            this.radPlayerRock.Location = new System.Drawing.Point(39, 59);
            this.radPlayerRock.Margin = new System.Windows.Forms.Padding(4);
            this.radPlayerRock.Name = "radPlayerRock";
            this.radPlayerRock.Size = new System.Drawing.Size(61, 21);
            this.radPlayerRock.TabIndex = 0;
            this.radPlayerRock.TabStop = true;
            this.radPlayerRock.Text = "Rock";
            this.radPlayerRock.UseVisualStyleBackColor = true;
            // 
            // grbComputer
            // 
            this.grbComputer.Controls.Add(this.radComputerScissors);
            this.grbComputer.Controls.Add(this.radComputerPaper);
            this.grbComputer.Controls.Add(this.radComputerRock);
            this.grbComputer.Location = new System.Drawing.Point(48, 254);
            this.grbComputer.Margin = new System.Windows.Forms.Padding(4);
            this.grbComputer.Name = "grbComputer";
            this.grbComputer.Padding = new System.Windows.Forms.Padding(4);
            this.grbComputer.Size = new System.Drawing.Size(276, 225);
            this.grbComputer.TabIndex = 1;
            this.grbComputer.TabStop = false;
            this.grbComputer.Text = "Computer\'s Choice";
            // 
            // radComputerScissors
            // 
            this.radComputerScissors.AutoSize = true;
            this.radComputerScissors.Location = new System.Drawing.Point(44, 164);
            this.radComputerScissors.Margin = new System.Windows.Forms.Padding(4);
            this.radComputerScissors.Name = "radComputerScissors";
            this.radComputerScissors.Size = new System.Drawing.Size(82, 21);
            this.radComputerScissors.TabIndex = 2;
            this.radComputerScissors.TabStop = true;
            this.radComputerScissors.Text = "Scissors";
            this.radComputerScissors.UseVisualStyleBackColor = true;
            // 
            // radComputerPaper
            // 
            this.radComputerPaper.AutoSize = true;
            this.radComputerPaper.Location = new System.Drawing.Point(44, 105);
            this.radComputerPaper.Margin = new System.Windows.Forms.Padding(4);
            this.radComputerPaper.Name = "radComputerPaper";
            this.radComputerPaper.Size = new System.Drawing.Size(67, 21);
            this.radComputerPaper.TabIndex = 1;
            this.radComputerPaper.TabStop = true;
            this.radComputerPaper.Text = "Paper";
            this.radComputerPaper.UseVisualStyleBackColor = true;
            // 
            // radComputerRock
            // 
            this.radComputerRock.AutoSize = true;
            this.radComputerRock.Location = new System.Drawing.Point(44, 48);
            this.radComputerRock.Margin = new System.Windows.Forms.Padding(4);
            this.radComputerRock.Name = "radComputerRock";
            this.radComputerRock.Size = new System.Drawing.Size(61, 21);
            this.radComputerRock.TabIndex = 0;
            this.radComputerRock.TabStop = true;
            this.radComputerRock.Text = "Rock";
            this.radComputerRock.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(48, 486);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(100, 28);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 554);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grbComputer);
            this.Controls.Add(this.grbPlayer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock, Paper, Scissors Tobi";
            this.Load += new System.EventHandler(this.FrmRockPaperScissors_Load);
            this.grbPlayer.ResumeLayout(false);
            this.grbPlayer.PerformLayout();
            this.grbComputer.ResumeLayout(false);
            this.grbComputer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPlayer;
        private System.Windows.Forms.GroupBox grbComputer;
        private System.Windows.Forms.RadioButton radPlayerScissors;
        private System.Windows.Forms.RadioButton radPlayerPaper;
        private System.Windows.Forms.RadioButton radPlayerRock;
        private System.Windows.Forms.RadioButton radComputerScissors;
        private System.Windows.Forms.RadioButton radComputerPaper;
        private System.Windows.Forms.RadioButton radComputerRock;
        private System.Windows.Forms.Button btnPlay;
    }
}

