namespace WinFormdRandomNum
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HighBox = new System.Windows.Forms.TextBox();
            this.LowBox = new System.Windows.Forms.TextBox();
            this.GenBtn = new System.Windows.Forms.Button();
            this.LabelOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HighBox
            // 
            this.HighBox.Location = new System.Drawing.Point(12, 102);
            this.HighBox.Name = "HighBox";
            this.HighBox.Size = new System.Drawing.Size(173, 23);
            this.HighBox.TabIndex = 1;
            // 
            // LowBox
            // 
            this.LowBox.Location = new System.Drawing.Point(12, 131);
            this.LowBox.Name = "LowBox";
            this.LowBox.Size = new System.Drawing.Size(173, 23);
            this.LowBox.TabIndex = 2;
            // 
            // GenBtn
            // 
            this.GenBtn.Location = new System.Drawing.Point(12, 60);
            this.GenBtn.Name = "GenBtn";
            this.GenBtn.Size = new System.Drawing.Size(173, 36);
            this.GenBtn.TabIndex = 3;
            this.GenBtn.Text = "Generate";
            this.GenBtn.UseVisualStyleBackColor = true;
            this.GenBtn.Click += new System.EventHandler(this.BtnCliclk);
            // 
            // LabelOut
            // 
            this.LabelOut.AutoSize = true;
            this.LabelOut.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelOut.Location = new System.Drawing.Point(12, 9);
            this.LabelOut.Name = "LabelOut";
            this.LabelOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelOut.Size = new System.Drawing.Size(23, 28);
            this.LabelOut.TabIndex = 4;
            this.LabelOut.Text = "0";
            this.LabelOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 158);
            this.Controls.Add(this.LabelOut);
            this.Controls.Add(this.GenBtn);
            this.Controls.Add(this.LowBox);
            this.Controls.Add(this.HighBox);
            this.Name = "Form1";
            this.Text = "Random";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox HighBox;
        private TextBox LowBox;
        private Button GenBtn;
        private Label LabelOut;
    }
}