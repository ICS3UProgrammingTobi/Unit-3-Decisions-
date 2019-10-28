namespace WindowsFormsApp1
{
    partial class frmRunningAverage
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtAvrage = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(12, 67);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(276, 20);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Enter a number (from 0 to 100):";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(33, 119);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(144, 20);
            this.lblExit.TabIndex = 1;
            this.lblExit.Text = "Type \"-1\" to exit";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(13, 252);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(59, 20);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "label1";
            // 
            // txtAvrage
            // 
            this.txtAvrage.Location = new System.Drawing.Point(324, 65);
            this.txtAvrage.Name = "txtAvrage";
            this.txtAvrage.Size = new System.Drawing.Size(103, 22);
            this.txtAvrage.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(37, 174);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(106, 37);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmRunningAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 341);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAvrage);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblNumber);
            this.Name = "frmRunningAverage";
            this.Text = "Running Average Tobi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtAvrage;
        private System.Windows.Forms.Button btnCalculate;
    }
}

