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
            this.label_AboutBox = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label_Monitor_Manager = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Product_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Product_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // label_AboutBox
            // 
            this.label_AboutBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label_AboutBox.Location = new System.Drawing.Point(35, 40);
            this.label_AboutBox.Name = "label_AboutBox";
            this.label_AboutBox.Size = new System.Drawing.Size(83, 24);
            this.label_AboutBox.TabIndex = 1;
            this.label_AboutBox.Text = "About...";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(43, 457);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(74, 12);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "License Info";
            // 
            // label_Monitor_Manager
            // 
            this.label_Monitor_Manager.AutoSize = true;
            this.label_Monitor_Manager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label_Monitor_Manager.Location = new System.Drawing.Point(35, 95);
            this.label_Monitor_Manager.Name = "label_Monitor_Manager";
            this.label_Monitor_Manager.Size = new System.Drawing.Size(132, 12);
            this.label_Monitor_Manager.TabIndex = 6;
            this.label_Monitor_Manager.Text = "Multi Monitor Manager";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pictureBox1.Location = new System.Drawing.Point(272, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 2);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pictureBox4.Location = new System.Drawing.Point(272, 6);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(2, 506);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox_Product_Image
            // 
            this.pictureBox_Product_Image.Location = new System.Drawing.Point(303, 72);
            this.pictureBox_Product_Image.Name = "pictureBox_Product_Image";
            this.pictureBox_Product_Image.Size = new System.Drawing.Size(448, 317);
            this.pictureBox_Product_Image.TabIndex = 7;
            this.pictureBox_Product_Image.TabStop = false;
            // 
            // AboutBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(769, 506);
            this.Controls.Add(this.pictureBox_Product_Image);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Monitor_Manager);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label_AboutBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Opacity = 0.96D;
            this.Text = "LG USB-Hub Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Product_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion
        private System.Windows.Forms.Label label_AboutBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        //private System.Windows.Forms.Button button_Test;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.Label label_Monitor_Manager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox_Product_Image;
    }
}