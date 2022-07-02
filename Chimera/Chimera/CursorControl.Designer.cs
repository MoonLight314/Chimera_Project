namespace Chimera
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
            this.btn_Cursor_Lock_Screen_KeyChange = new System.Windows.Forms.Button();
            this.txtBox_Hotkey_LockToScreen = new System.Windows.Forms.TextBox();
            //this.cb_LockToScreen = new System.Windows.Forms.CheckBox();
            this.btn_CursorMov_Prev_Screen_KeyChange = new System.Windows.Forms.Button();
            this.txtBox_Hotkey_MovCurPrevScreen = new System.Windows.Forms.TextBox();
            this.btn_CursorMov_Next_Screen_KeyChange = new System.Windows.Forms.Button();
            this.txtBox_Hotkey_MovCurNextScreen = new System.Windows.Forms.TextBox();
            this.cursorControl_Reset = new System.Windows.Forms.Button();
            this.label_CursorControl = new System.Windows.Forms.Label();
            this.pictureBox_CursorControl_Comment = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label_Feature_Enable = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_Features = new System.Windows.Forms.Label();
            this.label_FeatureEnable = new System.Windows.Forms.Label();
            this.pb_CheckBox_FeatureEnable = new System.Windows.Forms.PictureBox();
            this.pb_CheckBox_MovCursorNextScreen = new System.Windows.Forms.PictureBox();
            this.label_MovCursorNextScreen = new System.Windows.Forms.Label();
            this.pb_CheckBox_MovCursorPrevScreen = new System.Windows.Forms.PictureBox();
            this.label_MovCursorPrevScreen = new System.Windows.Forms.Label();
            this.pb_CheckBox_MovCursorPrimary = new System.Windows.Forms.PictureBox();
            this.label_MovCursorPrimary = new System.Windows.Forms.Label();
            this.pb_CheckBox_LockToScreen = new System.Windows.Forms.PictureBox();
            this.label_LockToScreen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CursorControl_Comment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CheckBox_FeatureEnable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CheckBox_MovCursorNextScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CheckBox_MovCursorPrevScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CheckBox_MovCursorPrimary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CheckBox_LockToScreen)).BeginInit();
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
            this.txtBox_Hotkey_MoveCurPrimary.Size = new System.Drawing.Size(153, 22);
            this.txtBox_Hotkey_MoveCurPrimary.TabIndex = 12;
            this.txtBox_Hotkey_MoveCurPrimary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Hotkey_MoveCurPrimary.Enter += new System.EventHandler(this.txtBox_Hotkey_MoveCurPrimary_Enter);
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
            this.txtBox_Hotkey_LockToScreen.Size = new System.Drawing.Size(153, 22);
            this.txtBox_Hotkey_LockToScreen.TabIndex = 9;
            this.txtBox_Hotkey_LockToScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Hotkey_LockToScreen.Enter += new System.EventHandler(this.txtBox_Hotkey_LockToScreen_Enter);

#if TEST
            // 
            // cb_LockToScreen
            // 
            this.cb_LockToScreen.AutoSize = true;
            this.cb_LockToScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.cb_LockToScreen.Location = new System.Drawing.Point(304, 304);
            this.cb_LockToScreen.Name = "cb_LockToScreen";
            this.cb_LockToScreen.Size = new System.Drawing.Size(197, 18);
            this.cb_LockToScreen.TabIndex = 8;
            this.cb_LockToScreen.Text = " Lock / Unlock To Screen";
            this.cb_LockToScreen.UseVisualStyleBackColor = true;
            this.cb_LockToScreen.CheckedChanged += new System.EventHandler(this.cb_LockScreen_ChangeCheck);
#endif

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
            this.txtBox_Hotkey_MovCurPrevScreen.Size = new System.Drawing.Size(153, 22);
            this.txtBox_Hotkey_MovCurPrevScreen.TabIndex = 6;
            this.txtBox_Hotkey_MovCurPrevScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Hotkey_MovCurPrevScreen.Enter += new System.EventHandler(this.txtBox_Hotkey_MovCurPrevScreen_Enter);
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
            this.txtBox_Hotkey_MovCurNextScreen.Size = new System.Drawing.Size(153, 22);
            this.txtBox_Hotkey_MovCurNextScreen.TabIndex = 1;
            this.txtBox_Hotkey_MovCurNextScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_Hotkey_MovCurNextScreen.Enter += new System.EventHandler(this.txtBox_Hotkey_MovCurNextScreen_Enter);
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
            // label_CursorControl
            // 
            this.label_CursorControl.AutoSize = true;
            this.label_CursorControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label_CursorControl.Location = new System.Drawing.Point(35, 40);
            this.label_CursorControl.Name = "label_CursorControl";
            this.label_CursorControl.Size = new System.Drawing.Size(102, 14);
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
            this.label_Feature_Enable.Size = new System.Drawing.Size(104, 14);
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
            this.label_Features.Size = new System.Drawing.Size(63, 14);
            this.label_Features.TabIndex = 26;
            this.label_Features.Text = "Features";
            // 
            // label_FeatureEnable
            // 
            this.label_FeatureEnable.AutoSize = true;
            this.label_FeatureEnable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.label_FeatureEnable.Location = new System.Drawing.Point(323, 76);
            this.label_FeatureEnable.Name = "label_FeatureEnable";
            this.label_FeatureEnable.Size = new System.Drawing.Size(160, 14);
            this.label_FeatureEnable.TabIndex = 27;
            this.label_FeatureEnable.Text = "Enable Cursor Features";
            // 
            // pb_CheckBox_FeatureEnable
            // 
            this.pb_CheckBox_FeatureEnable.Location = new System.Drawing.Point(684, 75);
            this.pb_CheckBox_FeatureEnable.Name = "pb_CheckBox_FeatureEnable";
            this.pb_CheckBox_FeatureEnable.Size = new System.Drawing.Size(44, 22);
            this.pb_CheckBox_FeatureEnable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_CheckBox_FeatureEnable.TabIndex = 28;
            this.pb_CheckBox_FeatureEnable.TabStop = false;
            this.pb_CheckBox_FeatureEnable.Click += new System.EventHandler(this.pb_CheckBox_FeatureEnable_Click);
            // 
            // pb_CheckBox_MovCursorNextScreen
            // 
            this.pb_CheckBox_MovCursorNextScreen.Location = new System.Drawing.Point(306, 185);
            this.pb_CheckBox_MovCursorNextScreen.Name = "pb_CheckBox_MovCursorNextScreen";
            this.pb_CheckBox_MovCursorNextScreen.Size = new System.Drawing.Size(16, 16);
            this.pb_CheckBox_MovCursorNextScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_CheckBox_MovCursorNextScreen.TabIndex = 30;
            this.pb_CheckBox_MovCursorNextScreen.TabStop = false;
            this.pb_CheckBox_MovCursorNextScreen.Click += new System.EventHandler(this.pb_CheckBox_MovCursorNextScreen_Click);
            // 
            // label_MovCursorNextScreen
            // 
            this.label_MovCursorNextScreen.AutoSize = true;
            this.label_MovCursorNextScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.label_MovCursorNextScreen.Location = new System.Drawing.Point(325, 186);
            this.label_MovCursorNextScreen.Name = "label_MovCursorNextScreen";
            this.label_MovCursorNextScreen.Size = new System.Drawing.Size(200, 14);
            this.label_MovCursorNextScreen.TabIndex = 29;
            this.label_MovCursorNextScreen.Text = "Move Cursor To Next Screen";
            // 
            // pb_CheckBox_MovCursorPrevScreen
            // 
            this.pb_CheckBox_MovCursorPrevScreen.Location = new System.Drawing.Point(303, 221);
            this.pb_CheckBox_MovCursorPrevScreen.Name = "pb_CheckBox_MovCursorPrevScreen";
            this.pb_CheckBox_MovCursorPrevScreen.Size = new System.Drawing.Size(16, 16);
            this.pb_CheckBox_MovCursorPrevScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_CheckBox_MovCursorPrevScreen.TabIndex = 32;
            this.pb_CheckBox_MovCursorPrevScreen.TabStop = false;
            this.pb_CheckBox_MovCursorPrevScreen.Click += new System.EventHandler(this.pb_CheckBox_MovCursorPrevScreen_Click);
            // 
            // label_MovCursorPrevScreen
            // 
            this.label_MovCursorPrevScreen.AutoSize = true;
            this.label_MovCursorPrevScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.label_MovCursorPrevScreen.Location = new System.Drawing.Point(322, 222);
            this.label_MovCursorPrevScreen.Name = "label_MovCursorPrevScreen";
            this.label_MovCursorPrevScreen.Size = new System.Drawing.Size(228, 14);
            this.label_MovCursorPrevScreen.TabIndex = 31;
            this.label_MovCursorPrevScreen.Text = "Move Cursor To Previous Screen";
            // 
            // pb_CheckBox_MovCursorPrimary
            // 
            this.pb_CheckBox_MovCursorPrimary.Location = new System.Drawing.Point(306, 261);
            this.pb_CheckBox_MovCursorPrimary.Name = "pb_CheckBox_MovCursorPrimary";
            this.pb_CheckBox_MovCursorPrimary.Size = new System.Drawing.Size(16, 16);
            this.pb_CheckBox_MovCursorPrimary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_CheckBox_MovCursorPrimary.TabIndex = 34;
            this.pb_CheckBox_MovCursorPrimary.TabStop = false;
            this.pb_CheckBox_MovCursorPrimary.Click += new System.EventHandler(this.pb_CheckBox_MovCursorPrimary_Click);
            // 
            // label_MovCursorPrimary
            // 
            this.label_MovCursorPrimary.AutoSize = true;
            this.label_MovCursorPrimary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.label_MovCursorPrimary.Location = new System.Drawing.Point(325, 262);
            this.label_MovCursorPrimary.Name = "label_MovCursorPrimary";
            this.label_MovCursorPrimary.Size = new System.Drawing.Size(218, 14);
            this.label_MovCursorPrimary.TabIndex = 33;
            this.label_MovCursorPrimary.Text = "Move Cursor To Primary Screen";
            // 
            // pb_CheckBox_LockToScreen
            // 
            this.pb_CheckBox_LockToScreen.Location = new System.Drawing.Point(358, 287);
            this.pb_CheckBox_LockToScreen.Name = "pb_CheckBox_LockToScreen";
            this.pb_CheckBox_LockToScreen.Size = new System.Drawing.Size(16, 16);
            this.pb_CheckBox_LockToScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_CheckBox_LockToScreen.TabIndex = 36;
            this.pb_CheckBox_LockToScreen.TabStop = false;
            this.pb_CheckBox_LockToScreen.Click += new System.EventHandler(this.pb_CheckBox_LockToScreen_Click);
            // 
            // label_LockToScreen
            // 
            this.label_LockToScreen.AutoSize = true;
            this.label_LockToScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.label_LockToScreen.Location = new System.Drawing.Point(377, 288);
            this.label_LockToScreen.Name = "label_LockToScreen";
            this.label_LockToScreen.Size = new System.Drawing.Size(173, 14);
            this.label_LockToScreen.TabIndex = 35;
            this.label_LockToScreen.Text = "Lock / Unlock To Screen";
            // 
            // CursorControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(769, 506);
            this.Controls.Add(this.pb_CheckBox_LockToScreen);
            this.Controls.Add(this.label_LockToScreen);
            this.Controls.Add(this.pb_CheckBox_MovCursorPrimary);
            this.Controls.Add(this.label_MovCursorPrimary);
            this.Controls.Add(this.pb_CheckBox_MovCursorPrevScreen);
            this.Controls.Add(this.label_MovCursorPrevScreen);
            this.Controls.Add(this.pb_CheckBox_MovCursorNextScreen);
            this.Controls.Add(this.label_MovCursorNextScreen);
            this.Controls.Add(this.pb_CheckBox_FeatureEnable);
            this.Controls.Add(this.label_FeatureEnable);
            this.Controls.Add(this.label_Features);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_Feature_Enable);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_CursorControl_Comment);
            this.Controls.Add(this.label_CursorControl);
            this.Controls.Add(this.cursorControl_Reset);
            this.Controls.Add(this.btn_Cursor_Move_Primary_KeyChange);
            this.Controls.Add(this.txtBox_Hotkey_MoveCurPrimary);
            this.Controls.Add(this.btn_Cursor_Lock_Screen_KeyChange);
            this.Controls.Add(this.txtBox_Hotkey_LockToScreen);
            //this.Controls.Add(this.cb_LockToScreen);
            this.Controls.Add(this.btn_CursorMov_Prev_Screen_KeyChange);
            this.Controls.Add(this.txtBox_Hotkey_MovCurPrevScreen);
            this.Controls.Add(this.btn_CursorMov_Next_Screen_KeyChange);
            this.Controls.Add(this.txtBox_Hotkey_MovCurNextScreen);
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_CheckBox_FeatureEnable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CheckBox_MovCursorNextScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CheckBox_MovCursorPrevScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CheckBox_MovCursorPrimary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CheckBox_LockToScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private System.Windows.Forms.Button cursorControl_Set;
        //private System.Windows.Forms.Button cursorControl_Cancel;
        //private System.Windows.Forms.GroupBox grpBox_EachFeatures;
        //private System.Windows.Forms.CheckBox cb_MovCursorNextScreen;
        private System.Windows.Forms.Button btn_CursorMov_Next_Screen_KeyChange;
        private System.Windows.Forms.TextBox txtBox_Hotkey_MovCurNextScreen;
        private System.Windows.Forms.Button btn_CursorMov_Prev_Screen_KeyChange;
        private System.Windows.Forms.TextBox txtBox_Hotkey_MovCurPrevScreen;
        //private System.Windows.Forms.CheckBox cb_MovCursorPrevScreen;
        private System.Windows.Forms.Button btn_Cursor_Lock_Screen_KeyChange;
        private System.Windows.Forms.TextBox txtBox_Hotkey_LockToScreen;
        //private System.Windows.Forms.CheckBox cb_LockToScreen;
        private System.Windows.Forms.Button cursorControl_Reset;
        private System.Windows.Forms.Button btn_Cursor_Move_Primary_KeyChange;
        private System.Windows.Forms.TextBox txtBox_Hotkey_MoveCurPrimary;
        //private System.Windows.Forms.CheckBox cb_MovCursorPrimary;
        //private System.Windows.Forms.CheckBox cb_FeatureEnable;
        private System.Windows.Forms.Label label_CursorControl;
        private System.Windows.Forms.PictureBox pictureBox_CursorControl_Comment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label_Feature_Enable;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_Features;
        private System.Windows.Forms.Label label_FeatureEnable;
        private System.Windows.Forms.PictureBox pb_CheckBox_FeatureEnable;
        private System.Windows.Forms.PictureBox pb_CheckBox_MovCursorNextScreen;
        private System.Windows.Forms.Label label_MovCursorNextScreen;
        private System.Windows.Forms.PictureBox pb_CheckBox_MovCursorPrevScreen;
        private System.Windows.Forms.Label label_MovCursorPrevScreen;
        private System.Windows.Forms.PictureBox pb_CheckBox_MovCursorPrimary;
        private System.Windows.Forms.Label label_MovCursorPrimary;
        private System.Windows.Forms.PictureBox pb_CheckBox_LockToScreen;
        private System.Windows.Forms.Label label_LockToScreen;
        //private System.Windows.Forms.GroupBox grpBox_Feature_Enable;
    }
}