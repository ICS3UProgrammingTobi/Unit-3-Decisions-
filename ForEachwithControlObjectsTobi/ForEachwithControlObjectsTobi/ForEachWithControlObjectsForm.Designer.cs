namespace ForEachwithControlObjectsTobi
{
    partial class frmForEachWithControlObjects
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
            this.btnChangeColour = new System.Windows.Forms.Button();
            this.lblChangeColour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChangeColour
            // 
            this.btnChangeColour.Location = new System.Drawing.Point(52, 38);
            this.btnChangeColour.Name = "btnChangeColour";
            this.btnChangeColour.Size = new System.Drawing.Size(213, 64);
            this.btnChangeColour.TabIndex = 0;
            this.btnChangeColour.Text = "Change Colour";
            this.btnChangeColour.UseVisualStyleBackColor = true;
            this.btnChangeColour.Click += new System.EventHandler(this.btnChangeColour_Click);
            // 
            // lblChangeColour
            // 
            this.lblChangeColour.AutoSize = true;
            this.lblChangeColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeColour.Location = new System.Drawing.Point(46, 207);
            this.lblChangeColour.Name = "lblChangeColour";
            this.lblChangeColour.Size = new System.Drawing.Size(219, 32);
            this.lblChangeColour.TabIndex = 1;
            this.lblChangeColour.Text = "Change Colour";
            this.lblChangeColour.Click += new System.EventHandler(this.lblChangeColour_Click);
            // 
            // frmForEachWithControlObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 307);
            this.Controls.Add(this.lblChangeColour);
            this.Controls.Add(this.btnChangeColour);
            this.Name = "frmForEachWithControlObjects";
            this.Text = "For...Each with Control Objects Tobi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeColour;
        private System.Windows.Forms.Label lblChangeColour;
    }
}

