﻿namespace PerfectSquaresWithWhileLoopTobi
{
    partial class frmPerfectSquaresWithWhileLoop
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lstPerfectSquares = new System.Windows.Forms.ListBox();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(58, 44);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 47);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstPerfectSquares
            // 
            this.lstPerfectSquares.FormattingEnabled = true;
            this.lstPerfectSquares.ItemHeight = 16;
            this.lstPerfectSquares.Location = new System.Drawing.Point(42, 226);
            this.lstPerfectSquares.Name = "lstPerfectSquares";
            this.lstPerfectSquares.Size = new System.Drawing.Size(161, 180);
            this.lstPerfectSquares.TabIndex = 1;
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(58, 141);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(120, 22);
            this.nudNumber.TabIndex = 2;
            // 
            // frmPerfectSquaresWithWhileLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 450);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.lstPerfectSquares);
            this.Controls.Add(this.btnStart);
            this.Name = "frmPerfectSquaresWithWhileLoop";
            this.Text = "Perfect Squares with While Loop Tobi";
            this.Load += new System.EventHandler(this.frmPerfectSquaresWithWhileLoop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstPerfectSquares;
        private System.Windows.Forms.NumericUpDown nudNumber;
    }
}

