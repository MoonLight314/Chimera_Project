namespace Chimera
{
    partial class AboutBox
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
            this.aboutBox_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aboutBox_OK
            // 
            this.aboutBox_OK.Location = new System.Drawing.Point(196, 209);
            this.aboutBox_OK.Name = "aboutBox_OK";
            this.aboutBox_OK.Size = new System.Drawing.Size(75, 23);
            this.aboutBox_OK.TabIndex = 0;
            this.aboutBox_OK.Text = "OK";
            this.aboutBox_OK.UseVisualStyleBackColor = true;
            this.aboutBox_OK.Click += new System.EventHandler(this.aboutBox_OK_click);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.aboutBox_OK);
            this.Name = "AboutBox";
            this.Text = "AboutBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button aboutBox_OK;
    }
}