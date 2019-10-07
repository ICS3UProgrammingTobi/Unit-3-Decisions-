namespace ChocolateBoxesTobiAdebayo
{
    partial class frmChocolateBoxes
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
            this.lblBoxes = new System.Windows.Forms.Label();
            this.lblReward = new System.Windows.Forms.Label();
            this.txtNumberOfBoxes = new System.Windows.Forms.TextBox();
            this.btnGetReward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBoxes
            // 
            this.lblBoxes.AutoSize = true;
            this.lblBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxes.Location = new System.Drawing.Point(12, 71);
            this.lblBoxes.Name = "lblBoxes";
            this.lblBoxes.Size = new System.Drawing.Size(427, 31);
            this.lblBoxes.TabIndex = 0;
            this.lblBoxes.Text = "Enter the number of boxes sold:";
            this.lblBoxes.Click += new System.EventHandler(this.LblBoxes_Click);
            // 
            // lblReward
            // 
            this.lblReward.AutoSize = true;
            this.lblReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReward.Location = new System.Drawing.Point(206, 215);
            this.lblReward.Name = "lblReward";
            this.lblReward.Size = new System.Drawing.Size(92, 31);
            this.lblReward.TabIndex = 1;
            this.lblReward.Text = "label2";
            // 
            // txtNumberOfBoxes
            // 
            this.txtNumberOfBoxes.Location = new System.Drawing.Point(471, 82);
            this.txtNumberOfBoxes.Name = "txtNumberOfBoxes";
            this.txtNumberOfBoxes.Size = new System.Drawing.Size(110, 20);
            this.txtNumberOfBoxes.TabIndex = 2;
            // 
            // btnGetReward
            // 
            this.btnGetReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetReward.Location = new System.Drawing.Point(471, 137);
            this.btnGetReward.Name = "btnGetReward";
            this.btnGetReward.Size = new System.Drawing.Size(110, 27);
            this.btnGetReward.TabIndex = 3;
            this.btnGetReward.Text = "Get reward";
            this.btnGetReward.UseVisualStyleBackColor = true;
            // 
            // frmChocolateBoxes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(614, 287);
            this.Controls.Add(this.btnGetReward);
            this.Controls.Add(this.txtNumberOfBoxes);
            this.Controls.Add(this.lblReward);
            this.Controls.Add(this.lblBoxes);
            this.Name = "frmChocolateBoxes";
            this.Text = "Chocolate Boxes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBoxes;
        private System.Windows.Forms.Label lblReward;
        private System.Windows.Forms.TextBox txtNumberOfBoxes;
        private System.Windows.Forms.Button btnGetReward;
    }
}

