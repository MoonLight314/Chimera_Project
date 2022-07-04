
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
            this.Preview_PictureBox = new System.Windows.Forms.PictureBox();
            this.Label_Image_File_Path = new System.Windows.Forms.Label();
            this.TextBox_Image_File_Path = new System.Windows.Forms.TextBox();
            this.Button_Browse_Wallpaper = new System.Windows.Forms.Button();
            this.labelScreensSelected = new System.Windows.Forms.Label();
            this.comboBoxFit = new System.Windows.Forms.ComboBox();
            this.label_Wallpaper = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label_Choose_Fit = new System.Windows.Forms.Label();
            this.pictureBox_Wrap = new System.Windows.Forms.PictureBox();
            this.label_Introduction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Preview_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Wrap)).BeginInit();
            this.SuspendLayout();
            // 
            // Preview_PictureBox
            // 
            this.Preview_PictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Preview_PictureBox.Location = new System.Drawing.Point(341, 54);
            this.Preview_PictureBox.Name = "Preview_PictureBox";
            this.Preview_PictureBox.Size = new System.Drawing.Size(358, 192);
            this.Preview_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Preview_PictureBox.TabIndex = 2;
            this.Preview_PictureBox.TabStop = false;
            this.Preview_PictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picPreview_MouseClick);
            // 
            // Label_Image_File_Path
            // 
            this.Label_Image_File_Path.AutoSize = true;
            this.Label_Image_File_Path.Location = new System.Drawing.Point(300, 304);
            this.Label_Image_File_Path.Name = "Label_Image_File_Path";
            this.Label_Image_File_Path.Size = new System.Drawing.Size(93, 12);
            this.Label_Image_File_Path.TabIndex = 3;
            this.Label_Image_File_Path.Text = "Select a picture";
            // 
            // TextBox_Image_File_Path
            // 
            this.TextBox_Image_File_Path.BackColor = System.Drawing.Color.White;
            this.TextBox_Image_File_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Image_File_Path.Location = new System.Drawing.Point(440, 300);
            this.TextBox_Image_File_Path.Name = "TextBox_Image_File_Path";
            this.TextBox_Image_File_Path.ReadOnly = true;
            this.TextBox_Image_File_Path.Size = new System.Drawing.Size(247, 21);
            this.TextBox_Image_File_Path.TabIndex = 4;
            this.TextBox_Image_File_Path.TabStop = false;
            this.TextBox_Image_File_Path.Enter += new System.EventHandler(this.TextBox_Image_File_Path_Enter);
            // 
            // Button_Browse_Wallpaper
            // 
            this.Button_Browse_Wallpaper.BackColor = System.Drawing.Color.White;
            this.Button_Browse_Wallpaper.BackgroundImage = global::Chimera.Properties.Resources.Browse;
            this.Button_Browse_Wallpaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Browse_Wallpaper.Location = new System.Drawing.Point(667, 300);
            this.Button_Browse_Wallpaper.Name = "Button_Browse_Wallpaper";
            this.Button_Browse_Wallpaper.Size = new System.Drawing.Size(21, 22);
            this.Button_Browse_Wallpaper.TabIndex = 5;
            this.Button_Browse_Wallpaper.TabStop = false;
            this.Button_Browse_Wallpaper.UseVisualStyleBackColor = false;
            this.Button_Browse_Wallpaper.Click += new System.EventHandler(this.Button_Browse_Wallpaper_Click);
            // 
            // labelScreensSelected
            // 
            this.labelScreensSelected.AutoSize = true;
            this.labelScreensSelected.ForeColor = System.Drawing.Color.Black;
            this.labelScreensSelected.Location = new System.Drawing.Point(571, 474);
            this.labelScreensSelected.Name = "labelScreensSelected";
            this.labelScreensSelected.Size = new System.Drawing.Size(128, 12);
            this.labelScreensSelected.TabIndex = 8;
            this.labelScreensSelected.Text = "labelScreensSelected";
            // 
            // comboBoxFit
            // 
            this.comboBoxFit.BackColor = System.Drawing.Color.White;
            this.comboBoxFit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFit.FormattingEnabled = true;
            this.comboBoxFit.Location = new System.Drawing.Point(440, 340);
            this.comboBoxFit.Name = "comboBoxFit";
            this.comboBoxFit.Size = new System.Drawing.Size(247, 20);
            this.comboBoxFit.TabIndex = 9;
            this.comboBoxFit.SelectedIndexChanged += new System.EventHandler(this.ChangedStretchMode);
            // 
            // label_Wallpaper
            // 
            this.label_Wallpaper.AutoSize = true;
            this.label_Wallpaper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label_Wallpaper.Location = new System.Drawing.Point(35, 40);
            this.label_Wallpaper.Name = "label_Wallpaper";
            this.label_Wallpaper.Size = new System.Drawing.Size(60, 12);
            this.label_Wallpaper.TabIndex = 10;
            this.label_Wallpaper.Text = "Wallpaper";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pictureBox1.Location = new System.Drawing.Point(272, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 2);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pictureBox4.Location = new System.Drawing.Point(272, 6);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(2, 506);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // label_Choose_Fit
            // 
            this.label_Choose_Fit.AutoSize = true;
            this.label_Choose_Fit.Location = new System.Drawing.Point(300, 344);
            this.label_Choose_Fit.Name = "label_Choose_Fit";
            this.label_Choose_Fit.Size = new System.Drawing.Size(73, 12);
            this.label_Choose_Fit.TabIndex = 13;
            this.label_Choose_Fit.Text = "Choose a fit";
            // 
            // pictureBox_Wrap
            // 
            this.pictureBox_Wrap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_Wrap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Wrap.Location = new System.Drawing.Point(296, 30);
            this.pictureBox_Wrap.Name = "pictureBox_Wrap";
            this.pictureBox_Wrap.Size = new System.Drawing.Size(448, 240);
            this.pictureBox_Wrap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Wrap.TabIndex = 14;
            this.pictureBox_Wrap.TabStop = false;
            // 
            // label_Introduction
            // 
            this.label_Introduction.AutoSize = true;
            this.label_Introduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label_Introduction.Location = new System.Drawing.Point(40, 100);
            this.label_Introduction.Name = "label_Introduction";
            this.label_Introduction.Size = new System.Drawing.Size(0, 12);
            this.label_Introduction.TabIndex = 38;
            // 
            // SettingWallpaper
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 506);
            this.Controls.Add(this.label_Introduction);
            this.Controls.Add(this.label_Choose_Fit);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Wallpaper);
            this.Controls.Add(this.comboBoxFit);
            this.Controls.Add(this.labelScreensSelected);
            this.Controls.Add(this.Button_Browse_Wallpaper);
            this.Controls.Add(this.TextBox_Image_File_Path);
            this.Controls.Add(this.Label_Image_File_Path);
            this.Controls.Add(this.Preview_PictureBox);
            this.Controls.Add(this.pictureBox_Wrap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingWallpaper";
            this.Opacity = 0.94D;
            this.Text = "LG USB-Hub Manager";
            ((System.ComponentModel.ISupportInitialize)(this.Preview_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Wrap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        //private System.Windows.Forms.Button ID_Exit;
        //private System.Windows.Forms.Button Set_Wallpaper;
        private System.Windows.Forms.PictureBox Preview_PictureBox;
        private System.Windows.Forms.Label Label_Image_File_Path;
        private System.Windows.Forms.TextBox TextBox_Image_File_Path;
        private System.Windows.Forms.Button Button_Browse_Wallpaper;
        private System.Windows.Forms.Label labelScreensSelected;
        private System.Windows.Forms.ComboBox comboBoxFit;
        private System.Windows.Forms.Label label_Wallpaper;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label_Choose_Fit;
        private System.Windows.Forms.PictureBox pictureBox_Wrap;
        private System.Windows.Forms.Label label_Introduction;
    }
}