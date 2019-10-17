namespace GuessNumberTobiAdebayo
{
    partial class frmGuessNumber
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
            this.lblInteger = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblWrong = new System.Windows.Forms.Label();
            this.picX = new System.Windows.Forms.PictureBox();
            this.picCheck = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInteger
            // 
            this.lblInteger.AutoSize = true;
            this.lblInteger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteger.Location = new System.Drawing.Point(12, 85);
            this.lblInteger.Name = "lblInteger";
            this.lblInteger.Size = new System.Drawing.Size(386, 25);
            this.lblInteger.TabIndex = 0;
            this.lblInteger.Text = "Guess an integer between 1 and 10";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(36, 170);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(465, 85);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 20);
            this.txtAnswer.TabIndex = 2;
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRight.Location = new System.Drawing.Point(244, 166);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(255, 25);
            this.lblRight.TabIndex = 3;
            this.lblRight.Text = "You guessed correctly!";
            this.lblRight.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong.Location = new System.Drawing.Point(244, 232);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(220, 25);
            this.lblWrong.TabIndex = 4;
            this.lblWrong.Text = "You guessed wrong";
            // 
            // picX
            // 
            this.picX.Image = global::GuessNumberTobiAdebayo.Properties.Resources.red_x;
            this.picX.Location = new System.Drawing.Point(529, 207);
            this.picX.Name = "picX";
            this.picX.Size = new System.Drawing.Size(100, 50);
            this.picX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picX.TabIndex = 6;
            this.picX.TabStop = false;
            // 
            // picCheck
            // 
            this.picCheck.Image = global::GuessNumberTobiAdebayo.Properties.Resources.checkmark;
            this.picCheck.Location = new System.Drawing.Point(529, 141);
            this.picCheck.Name = "picCheck";
            this.picCheck.Size = new System.Drawing.Size(100, 50);
            this.picCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheck.TabIndex = 5;
            this.picCheck.TabStop = false;
            // 
            // frmGuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 364);
            this.Controls.Add(this.picX);
            this.Controls.Add(this.picCheck);
            this.Controls.Add(this.lblWrong);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblInteger);
            this.Name = "frmGuessNumber";
            this.Text = "Guess number by Tobi";
            ((System.ComponentModel.ISupportInitialize)(this.picX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInteger;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.PictureBox picCheck;
        private System.Windows.Forms.PictureBox picX;
    }
}

