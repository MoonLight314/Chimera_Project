namespace Chimera
{
    partial class ModernUIBasePanel
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
            this.btn_AboutBox = new System.Windows.Forms.Button();
            this.btn_Cursor = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.btn_Manage = new System.Windows.Forms.Button();
            this.btn_Wallpaper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AboutBox
            // 
            this.btn_AboutBox.FlatAppearance.BorderSize = 0;
            this.btn_AboutBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_AboutBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AboutBox.Location = new System.Drawing.Point(0, 0);
            this.btn_AboutBox.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AboutBox.Name = "btn_AboutBox";
            this.btn_AboutBox.Size = new System.Drawing.Size(170, 60);
            this.btn_AboutBox.TabIndex = 0;
            this.btn_AboutBox.TabStop = false;
            this.btn_AboutBox.Text = "About...";
            this.btn_AboutBox.UseVisualStyleBackColor = true;
            this.btn_AboutBox.Click += new System.EventHandler(this.btn_AboutBox_Click);
            this.btn_AboutBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // btn_Cursor
            // 
            this.btn_Cursor.FlatAppearance.BorderSize = 0;
            this.btn_Cursor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Cursor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cursor.Location = new System.Drawing.Point(0, 60);
            this.btn_Cursor.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Cursor.Name = "btn_Cursor";
            this.btn_Cursor.Size = new System.Drawing.Size(170, 60);
            this.btn_Cursor.TabIndex = 1;
            this.btn_Cursor.TabStop = false;
            this.btn_Cursor.Text = "Cursor Control";
            this.btn_Cursor.UseVisualStyleBackColor = true;
            this.btn_Cursor.Click += new System.EventHandler(this.btn_Cursor_Click);
            this.btn_Cursor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // panelForm
            // 
            this.panelForm.Location = new System.Drawing.Point(183, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(767, 512);
            this.panelForm.TabIndex = 2;
            // 
            // btn_Manage
            // 
            this.btn_Manage.FlatAppearance.BorderSize = 0;
            this.btn_Manage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Manage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Manage.Location = new System.Drawing.Point(0, 120);
            this.btn_Manage.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Manage.Name = "btn_Manage";
            this.btn_Manage.Size = new System.Drawing.Size(170, 60);
            this.btn_Manage.TabIndex = 3;
            this.btn_Manage.TabStop = false;
            this.btn_Manage.Text = "Manage";
            this.btn_Manage.UseVisualStyleBackColor = true;
            this.btn_Manage.Click += new System.EventHandler(this.btn_Manage_Click);
            this.btn_Manage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // btn_Wallpaper
            // 
            this.btn_Wallpaper.FlatAppearance.BorderSize = 0;
            this.btn_Wallpaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Wallpaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Wallpaper.Location = new System.Drawing.Point(0, 180);
            this.btn_Wallpaper.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Wallpaper.Name = "btn_Wallpaper";
            this.btn_Wallpaper.Size = new System.Drawing.Size(170, 60);
            this.btn_Wallpaper.TabIndex = 4;
            this.btn_Wallpaper.TabStop = false;
            this.btn_Wallpaper.Text = "Wallpaper";
            this.btn_Wallpaper.UseVisualStyleBackColor = true;
            this.btn_Wallpaper.Click += new System.EventHandler(this.btn_Wallpaper_Click);
            this.btn_Wallpaper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // ModernUIBasePanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(954, 515);
            this.Controls.Add(this.btn_Wallpaper);
            this.Controls.Add(this.btn_Manage);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.btn_Cursor);
            this.Controls.Add(this.btn_AboutBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModernUIBasePanel";
            this.Opacity = 0.96D;
            this.Text = "LG USB-Hub Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModernUIBasePanel_FormClosed);
            this.Load += new System.EventHandler(this.ModernUIBasePanel_Load);
            this.Shown += new System.EventHandler(this.ModernUIBasePanel_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AboutBox;
        private System.Windows.Forms.Button btn_Cursor;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button btn_Manage;
        private System.Windows.Forms.Button btn_Wallpaper;
    }
}