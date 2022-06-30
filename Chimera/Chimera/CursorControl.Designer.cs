﻿namespace Chimera
{
    partial class CursorControl
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
            this.cursorControl_Set = new System.Windows.Forms.Button();
            this.btn_Cursor_Move_Primary_KeyChange = new System.Windows.Forms.Button();
            this.txtBox_Hotkey_MoveCurPrimary = new System.Windows.Forms.TextBox();
            this.cb_MovCursorPrimary = new System.Windows.Forms.CheckBox();
            this.btn_Cursor_Lock_Screen_KeyChange = new System.Windows.Forms.Button();
            this.txtBox_Hotkey_LockToScreen = new System.Windows.Forms.TextBox();
            this.cb_LockToScreen = new System.Windows.Forms.CheckBox();
            this.btn_CursorMov_Prev_Screen_KeyChange = new System.Windows.Forms.Button();
            this.txtBox_Hotkey_MovCurPrevScreen = new System.Windows.Forms.TextBox();
            this.cb_MovCursorPrevScreen = new System.Windows.Forms.CheckBox();
            this.btn_CursorMov_Next_Screen_KeyChange = new System.Windows.Forms.Button();
            this.txtBox_Hotkey_MovCurNextScreen = new System.Windows.Forms.TextBox();
            this.cb_MovCursorNextScreen = new System.Windows.Forms.CheckBox();
            this.cursorControl_Reset = new System.Windows.Forms.Button();
            this.cb_FeatureEnable = new System.Windows.Forms.CheckBox();
            this.label_CursorControl = new System.Windows.Forms.Label();
            this.pictureBox_CursorControl_Comment = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label_Feature_Enable = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_Features = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CursorControl_Comment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cursorControl_Set
            // 
            this.cursorControl_Set.Location = new System.Drawing.Point(22, 441);
            this.cursorControl_Set.Name = "cursorControl_Set";
            this.cursorControl_Set.Size = new System.Drawing.Size(102, 34);
            this.cursorControl_Set.TabIndex = 0;
            this.cursorControl_Set.Text = "SET";
            this.cursorControl_Set.UseVisualStyleBackColor = true;
            this.cursorControl_Set.Click += new System.EventHandler(this.cursorControl_Set_click);
            // 
            // btn_Cursor_Move_Primary_KeyChange
            // 
            this.btn_Cursor_Move_Primary_KeyChange.Location = new System.Drawing.Point(716, 264);
            this.btn_Cursor_Move_Primary_KeyChange.Name = "btn_Cursor_Move_Primary_KeyChange";
            this.btn_Cursor_Move_Primary_KeyChange.Size = new System.Drawing.Size(43, 21);
            this.btn_Cursor_Move_Primary_KeyChange.TabIndex = 13;
            this.btn_Cursor_Move_Primary_KeyChange.Text = "Change...";
            this.btn_Cursor_Move_Primary_KeyChange.UseVisualStyleBackColor = true;
            this.btn_Cursor_Move_Primary_KeyChange.MouseCaptureChanged += new System.EventHandler(this.btn_Click_CursorMov_Primary_Screen_KeyChange);
            // 
            // txtBox_Hotkey_MoveCurPrimary
            // 
            this.txtBox_Hotkey_MoveCurPrimary.Location = new System.Drawing.Point(547, 264);
            this.txtBox_Hotkey_MoveCurPrimary.Name = "txtBox_Hotkey_MoveCurPrimary";
            this.txtBox_Hotkey_MoveCurPrimary.ReadOnly = true;
            this.txtBox_Hotkey_MoveCurPrimary.Size = new System.Drawing.Size(153, 21);
            this.txtBox_Hotkey_MoveCurPrimary.TabIndex = 12;
            this.txtBox_Hotkey_MoveCurPrimary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Hotkey_MoveCurPrimary.Enter += new System.EventHandler(this.txtBox_Hotkey_MoveCurPrimary_Enter);
            // 
            // cb_MovCursorPrimary
            // 
            this.cb_MovCursorPrimary.AutoSize = true;
            this.cb_MovCursorPrimary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.cb_MovCursorPrimary.Location = new System.Drawing.Point(304, 264);
            this.cb_MovCursorPrimary.Name = "cb_MovCursorPrimary";
            this.cb_MovCursorPrimary.Size = new System.Drawing.Size(212, 16);
            this.cb_MovCursorPrimary.TabIndex = 11;
            this.cb_MovCursorPrimary.Text = " Move Cursor To Primary Screen";
            this.cb_MovCursorPrimary.UseVisualStyleBackColor = true;
            this.cb_MovCursorPrimary.CheckedChanged += new System.EventHandler(this.cb_CursorPrimaryScreen_ChangeCheck);
            // 
            // btn_Cursor_Lock_Screen_KeyChange
            // 
            this.btn_Cursor_Lock_Screen_KeyChange.Location = new System.Drawing.Point(716, 304);
            this.btn_Cursor_Lock_Screen_KeyChange.Name = "btn_Cursor_Lock_Screen_KeyChange";
            this.btn_Cursor_Lock_Screen_KeyChange.Size = new System.Drawing.Size(43, 21);
            this.btn_Cursor_Lock_Screen_KeyChange.TabIndex = 10;
            this.btn_Cursor_Lock_Screen_KeyChange.Text = "Change...";
            this.btn_Cursor_Lock_Screen_KeyChange.UseVisualStyleBackColor = true;
            this.btn_Cursor_Lock_Screen_KeyChange.Click += new System.EventHandler(this.btn_Click_Cursor_Lock_Screen_KeyChange);
            // 
            // txtBox_Hotkey_LockToScreen
            // 
            this.txtBox_Hotkey_LockToScreen.Location = new System.Drawing.Point(547, 304);
            this.txtBox_Hotkey_LockToScreen.Name = "txtBox_Hotkey_LockToScreen";
            this.txtBox_Hotkey_LockToScreen.ReadOnly = true;
            this.txtBox_Hotkey_LockToScreen.Size = new System.Drawing.Size(153, 21);
            this.txtBox_Hotkey_LockToScreen.TabIndex = 9;
            this.txtBox_Hotkey_LockToScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Hotkey_LockToScreen.Enter += new System.EventHandler(this.txtBox_Hotkey_LockToScreen_Enter);
            // 
            // cb_LockToScreen
            // 
            this.cb_LockToScreen.AutoSize = true;
            this.cb_LockToScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.cb_LockToScreen.Location = new System.Drawing.Point(304, 304);
            this.cb_LockToScreen.Name = "cb_LockToScreen";
            this.cb_LockToScreen.Size = new System.Drawing.Size(170, 16);
            this.cb_LockToScreen.TabIndex = 8;
            this.cb_LockToScreen.Text = " Lock / Unlock To Screen";
            this.cb_LockToScreen.UseVisualStyleBackColor = true;
            this.cb_LockToScreen.CheckedChanged += new System.EventHandler(this.cb_LockScreen_ChangeCheck);
            // 
            // btn_CursorMov_Prev_Screen_KeyChange
            // 
            this.btn_CursorMov_Prev_Screen_KeyChange.Location = new System.Drawing.Point(716, 224);
            this.btn_CursorMov_Prev_Screen_KeyChange.Name = "btn_CursorMov_Prev_Screen_KeyChange";
            this.btn_CursorMov_Prev_Screen_KeyChange.Size = new System.Drawing.Size(43, 21);
            this.btn_CursorMov_Prev_Screen_KeyChange.TabIndex = 7;
            this.btn_CursorMov_Prev_Screen_KeyChange.Text = "Change...";
            this.btn_CursorMov_Prev_Screen_KeyChange.UseVisualStyleBackColor = true;
            this.btn_CursorMov_Prev_Screen_KeyChange.Click += new System.EventHandler(this.btn_Click_CursorMov_Prev_Screen_KeyChange);
            // 
            // txtBox_Hotkey_MovCurPrevScreen
            // 
            this.txtBox_Hotkey_MovCurPrevScreen.Location = new System.Drawing.Point(547, 224);
            this.txtBox_Hotkey_MovCurPrevScreen.Name = "txtBox_Hotkey_MovCurPrevScreen";
            this.txtBox_Hotkey_MovCurPrevScreen.ReadOnly = true;
            this.txtBox_Hotkey_MovCurPrevScreen.Size = new System.Drawing.Size(153, 21);
            this.txtBox_Hotkey_MovCurPrevScreen.TabIndex = 6;
            this.txtBox_Hotkey_MovCurPrevScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Hotkey_MovCurPrevScreen.Enter += new System.EventHandler(this.txtBox_Hotkey_MovCurPrevScreen_Enter);
            // 
            // cb_MovCursorPrevScreen
            // 
            this.cb_MovCursorPrevScreen.AutoSize = true;
            this.cb_MovCursorPrevScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.cb_MovCursorPrevScreen.Location = new System.Drawing.Point(304, 224);
            this.cb_MovCursorPrevScreen.Name = "cb_MovCursorPrevScreen";
            this.cb_MovCursorPrevScreen.Size = new System.Drawing.Size(217, 16);
            this.cb_MovCursorPrevScreen.TabIndex = 5;
            this.cb_MovCursorPrevScreen.Text = " Move Cursor To Previous Screen";
            this.cb_MovCursorPrevScreen.UseVisualStyleBackColor = true;
            this.cb_MovCursorPrevScreen.CheckedChanged += new System.EventHandler(this.cb_CursorPrevScreen_ChangeCheck);
            // 
            // btn_CursorMov_Next_Screen_KeyChange
            // 
            this.btn_CursorMov_Next_Screen_KeyChange.Location = new System.Drawing.Point(716, 184);
            this.btn_CursorMov_Next_Screen_KeyChange.Name = "btn_CursorMov_Next_Screen_KeyChange";
            this.btn_CursorMov_Next_Screen_KeyChange.Size = new System.Drawing.Size(43, 21);
            this.btn_CursorMov_Next_Screen_KeyChange.TabIndex = 4;
            this.btn_CursorMov_Next_Screen_KeyChange.Text = "Change...";
            this.btn_CursorMov_Next_Screen_KeyChange.UseVisualStyleBackColor = true;
            this.btn_CursorMov_Next_Screen_KeyChange.Click += new System.EventHandler(this.btn_Click_CursorMov_Next_Screen_KeyChange);
            // 
            // txtBox_Hotkey_MovCurNextScreen
            // 
            this.txtBox_Hotkey_MovCurNextScreen.Location = new System.Drawing.Point(547, 184);
            this.txtBox_Hotkey_MovCurNextScreen.Name = "txtBox_Hotkey_MovCurNextScreen";
            this.txtBox_Hotkey_MovCurNextScreen.ReadOnly = true;
            this.txtBox_Hotkey_MovCurNextScreen.Size = new System.Drawing.Size(153, 21);
            this.txtBox_Hotkey_MovCurNextScreen.TabIndex = 1;
            this.txtBox_Hotkey_MovCurNextScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Hotkey_MovCurNextScreen.Enter += new System.EventHandler(this.txtBox_Hotkey_MovCurNextScreen_Enter);
            // 
            // cb_MovCursorNextScreen
            // 
            this.cb_MovCursorNextScreen.AutoSize = true;
            this.cb_MovCursorNextScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.cb_MovCursorNextScreen.Location = new System.Drawing.Point(304, 184);
            this.cb_MovCursorNextScreen.Name = "cb_MovCursorNextScreen";
            this.cb_MovCursorNextScreen.Size = new System.Drawing.Size(194, 16);
            this.cb_MovCursorNextScreen.TabIndex = 0;
            this.cb_MovCursorNextScreen.Text = " Move Cursor To Next Screen";
            this.cb_MovCursorNextScreen.UseVisualStyleBackColor = true;
            this.cb_MovCursorNextScreen.CheckedChanged += new System.EventHandler(this.cb_CursorNextScreen_ChangeCheck);
            // 
            // cursorControl_Reset
            // 
            this.cursorControl_Reset.Location = new System.Drawing.Point(675, 340);
            this.cursorControl_Reset.Name = "cursorControl_Reset";
            this.cursorControl_Reset.Size = new System.Drawing.Size(57, 22);
            this.cursorControl_Reset.TabIndex = 4;
            this.cursorControl_Reset.Text = "Reset";
            this.cursorControl_Reset.UseVisualStyleBackColor = true;
            this.cursorControl_Reset.Click += new System.EventHandler(this.cursorControl_Reset_Click);
            // 
            // cb_FeatureEnable
            // 
            this.cb_FeatureEnable.AutoSize = true;
            this.cb_FeatureEnable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.cb_FeatureEnable.Location = new System.Drawing.Point(304, 83);
            this.cb_FeatureEnable.Name = "cb_FeatureEnable";
            this.cb_FeatureEnable.Size = new System.Drawing.Size(162, 16);
            this.cb_FeatureEnable.TabIndex = 0;
            this.cb_FeatureEnable.Text = " Enable Cursor Features";
            this.cb_FeatureEnable.UseVisualStyleBackColor = true;
            this.cb_FeatureEnable.CheckedChanged += new System.EventHandler(this.cb_FeatureEnable_ChangeCheck);
            // 
            // label_CursorControl
            // 
            this.label_CursorControl.AutoSize = true;
            this.label_CursorControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label_CursorControl.Location = new System.Drawing.Point(35, 40);
            this.label_CursorControl.Name = "label_CursorControl";
            this.label_CursorControl.Size = new System.Drawing.Size(87, 12);
            this.label_CursorControl.TabIndex = 14;
            this.label_CursorControl.Text = "Cursor Control";
            // 
            // pictureBox_CursorControl_Comment
            // 
            this.pictureBox_CursorControl_Comment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_CursorControl_Comment.Location = new System.Drawing.Point(40, 100);
            this.pictureBox_CursorControl_Comment.Name = "pictureBox_CursorControl_Comment";
            this.pictureBox_CursorControl_Comment.Size = new System.Drawing.Size(192, 120);
            this.pictureBox_CursorControl_Comment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_CursorControl_Comment.TabIndex = 15;
            this.pictureBox_CursorControl_Comment.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pictureBox1.Location = new System.Drawing.Point(272, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 2);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pictureBox4.Location = new System.Drawing.Point(272, 6);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(2, 506);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // label_Feature_Enable
            // 
            this.label_Feature_Enable.AutoSize = true;
            this.label_Feature_Enable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label_Feature_Enable.Location = new System.Drawing.Point(304, 42);
            this.label_Feature_Enable.Name = "label_Feature_Enable";
            this.label_Feature_Enable.Size = new System.Drawing.Size(90, 12);
            this.label_Feature_Enable.TabIndex = 18;
            this.label_Feature_Enable.Text = "Feature Enable";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.pictureBox2.Location = new System.Drawing.Point(304, 125);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(430, 2);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // label_Features
            // 
            this.label_Features.AutoSize = true;
            this.label_Features.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label_Features.Location = new System.Drawing.Point(304, 150);
            this.label_Features.Name = "label_Features";
            this.label_Features.Size = new System.Drawing.Size(54, 12);
            this.label_Features.TabIndex = 26;
            this.label_Features.Text = "Features";
            // 
            // CursorControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(769, 506);
            this.Controls.Add(this.label_Features);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_Feature_Enable);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_CursorControl_Comment);
            this.Controls.Add(this.label_CursorControl);
            this.Controls.Add(this.cursorControl_Reset);
            this.Controls.Add(this.cb_FeatureEnable);
            this.Controls.Add(this.btn_Cursor_Move_Primary_KeyChange);
            this.Controls.Add(this.txtBox_Hotkey_MoveCurPrimary);
            this.Controls.Add(this.cb_MovCursorPrimary);
            this.Controls.Add(this.btn_Cursor_Lock_Screen_KeyChange);
            this.Controls.Add(this.txtBox_Hotkey_LockToScreen);
            this.Controls.Add(this.cb_LockToScreen);
            this.Controls.Add(this.btn_CursorMov_Prev_Screen_KeyChange);
            this.Controls.Add(this.txtBox_Hotkey_MovCurPrevScreen);
            this.Controls.Add(this.cb_MovCursorPrevScreen);
            this.Controls.Add(this.btn_CursorMov_Next_Screen_KeyChange);
            this.Controls.Add(this.txtBox_Hotkey_MovCurNextScreen);
            this.Controls.Add(this.cb_MovCursorNextScreen);
            this.Controls.Add(this.cursorControl_Set);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CursorControl";
            this.Opacity = 0.94D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LG USB-Hub Manager";
            this.Shown += new System.EventHandler(this.ShownForm);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CursorControl_Comment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private System.Windows.Forms.Button cursorControl_Set;
        //private System.Windows.Forms.Button cursorControl_Cancel;
        //private System.Windows.Forms.GroupBox grpBox_EachFeatures;
        private System.Windows.Forms.CheckBox cb_MovCursorNextScreen;
        private System.Windows.Forms.Button btn_CursorMov_Next_Screen_KeyChange;
        private System.Windows.Forms.TextBox txtBox_Hotkey_MovCurNextScreen;
        private System.Windows.Forms.Button btn_CursorMov_Prev_Screen_KeyChange;
        private System.Windows.Forms.TextBox txtBox_Hotkey_MovCurPrevScreen;
        private System.Windows.Forms.CheckBox cb_MovCursorPrevScreen;
        private System.Windows.Forms.Button btn_Cursor_Lock_Screen_KeyChange;
        private System.Windows.Forms.TextBox txtBox_Hotkey_LockToScreen;
        private System.Windows.Forms.CheckBox cb_LockToScreen;
        private System.Windows.Forms.Button cursorControl_Reset;
        private System.Windows.Forms.Button btn_Cursor_Move_Primary_KeyChange;
        private System.Windows.Forms.TextBox txtBox_Hotkey_MoveCurPrimary;
        private System.Windows.Forms.CheckBox cb_MovCursorPrimary;
        private System.Windows.Forms.CheckBox cb_FeatureEnable;
        private System.Windows.Forms.Label label_CursorControl;
        private System.Windows.Forms.PictureBox pictureBox_CursorControl_Comment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label_Feature_Enable;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_Features;
        //private System.Windows.Forms.GroupBox grpBox_Feature_Enable;
    }
}