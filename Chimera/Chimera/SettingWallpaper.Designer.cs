
using System.Drawing.Drawing2D;

namespace Chimera
{
    partial class SettingWallpaper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingWallpaper));
            this.ID_Exit = new System.Windows.Forms.Button();
            this.Set_Wallpaper = new System.Windows.Forms.Button();
            this.Preview_PictureBox = new System.Windows.Forms.PictureBox();
            this.Label_Image_File_Path = new System.Windows.Forms.Label();
            this.TextBox_Image_File_Path = new System.Windows.Forms.TextBox();
            this.Button_Browse_Wallpaper = new System.Windows.Forms.Button();
            this.labelScreensSelected = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFit = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Preview_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ID_Exit
            // 
            this.ID_Exit.Location = new System.Drawing.Point(547, 440);
            this.ID_Exit.Name = "ID_Exit";
            this.ID_Exit.Size = new System.Drawing.Size(180, 72);
            this.ID_Exit.TabIndex = 0;
            this.ID_Exit.Text = "Exit";
            this.ID_Exit.Click += new System.EventHandler(this.ID_Exit_Click);
            // 
            // Set_Wallpaper
            // 
            this.Set_Wallpaper.Location = new System.Drawing.Point(361, 440);
            this.Set_Wallpaper.Name = "Set_Wallpaper";
            this.Set_Wallpaper.Size = new System.Drawing.Size(180, 72);
            this.Set_Wallpaper.TabIndex = 1;
            this.Set_Wallpaper.Text = "Set Wallpaper";
            this.Set_Wallpaper.Click += new System.EventHandler(this.Set_Wallpaper_Click);
            // 
            // Preview_PictureBox
            // 
            this.Preview_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Preview_PictureBox.Location = new System.Drawing.Point(15, 49);
            this.Preview_PictureBox.Name = "Preview_PictureBox";
            this.Preview_PictureBox.Size = new System.Drawing.Size(712, 264);
            this.Preview_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Preview_PictureBox.TabIndex = 2;
            this.Preview_PictureBox.TabStop = false;
            this.Preview_PictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picPreview_MouseClick);
            // 
            // Label_Image_File_Path
            // 
            this.Label_Image_File_Path.AutoSize = true;
            this.Label_Image_File_Path.Location = new System.Drawing.Point(21, 343);
            this.Label_Image_File_Path.Name = "Label_Image_File_Path";
            this.Label_Image_File_Path.Size = new System.Drawing.Size(105, 12);
            this.Label_Image_File_Path.TabIndex = 3;
            this.Label_Image_File_Path.Text = "Image File Path : ";
            // 
            // TextBox_Image_File_Path
            // 
            this.TextBox_Image_File_Path.Location = new System.Drawing.Point(136, 338);
            this.TextBox_Image_File_Path.Name = "TextBox_Image_File_Path";
            this.TextBox_Image_File_Path.ReadOnly = true;
            this.TextBox_Image_File_Path.Size = new System.Drawing.Size(462, 21);
            this.TextBox_Image_File_Path.TabIndex = 4;
            // 
            // Button_Browse_Wallpaper
            // 
            this.Button_Browse_Wallpaper.Location = new System.Drawing.Point(604, 334);
            this.Button_Browse_Wallpaper.Name = "Button_Browse_Wallpaper";
            this.Button_Browse_Wallpaper.Size = new System.Drawing.Size(121, 30);
            this.Button_Browse_Wallpaper.TabIndex = 5;
            this.Button_Browse_Wallpaper.Text = "Browse...";
            this.Button_Browse_Wallpaper.UseVisualStyleBackColor = true;
            this.Button_Browse_Wallpaper.Click += new System.EventHandler(this.Button_Browse_Wallpaper_Click);
            // 
            // labelScreensSelected
            // 
            this.labelScreensSelected.ForeColor = System.Drawing.Color.Black;
            this.labelScreensSelected.Location = new System.Drawing.Point(127, 371);
            this.labelScreensSelected.Name = "labelScreensSelected";
            this.labelScreensSelected.Size = new System.Drawing.Size(344, 12);
            this.labelScreensSelected.TabIndex = 8;
            this.labelScreensSelected.Text = "labelScreensSelected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Screens selected:";
            // 
            // comboBoxFit
            // 
            this.comboBoxFit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFit.FormattingEnabled = true;
            this.comboBoxFit.Location = new System.Drawing.Point(15, 397);
            this.comboBoxFit.Name = "comboBoxFit";
            this.comboBoxFit.Size = new System.Drawing.Size(385, 20);
            this.comboBoxFit.TabIndex = 9;
            this.comboBoxFit.SelectedIndexChanged += new System.EventHandler(this.ChangedStretchMode);
            // 
            // SettingWallpaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(769, 506);
            this.Controls.Add(this.comboBoxFit);
            this.Controls.Add(this.labelScreensSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Browse_Wallpaper);
            this.Controls.Add(this.TextBox_Image_File_Path);
            this.Controls.Add(this.Label_Image_File_Path);
            this.Controls.Add(this.Preview_PictureBox);
            this.Controls.Add(this.Set_Wallpaper);
            this.Controls.Add(this.ID_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingWallpaper";
            this.ShowInTaskbar = false;
            this.Text = "Set Wallpaper";
            ((System.ComponentModel.ISupportInitialize)(this.Preview_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ID_Exit;
        private System.Windows.Forms.Button Set_Wallpaper;
        private System.Windows.Forms.PictureBox Preview_PictureBox;
        private System.Windows.Forms.Label Label_Image_File_Path;
        private System.Windows.Forms.TextBox TextBox_Image_File_Path;
        private System.Windows.Forms.Button Button_Browse_Wallpaper;
        private System.Windows.Forms.Label labelScreensSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFit;        
    }
}