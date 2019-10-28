namespace NestedLoopsTobi
{
    partial class frmNestedLoops
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
            this.lstAlphabets = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(84, 68);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(134, 55);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstAlphabets
            // 
            this.lstAlphabets.FormattingEnabled = true;
            this.lstAlphabets.ItemHeight = 16;
            this.lstAlphabets.Location = new System.Drawing.Point(84, 177);
            this.lstAlphabets.Name = "lstAlphabets";
            this.lstAlphabets.Size = new System.Drawing.Size(134, 228);
            this.lstAlphabets.TabIndex = 1;
            // 
            // frmNestedLoops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 450);
            this.Controls.Add(this.lstAlphabets);
            this.Controls.Add(this.btnStart);
            this.Name = "frmNestedLoops";
            this.Text = "Nested Loops Tobi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstAlphabets;
    }
}

