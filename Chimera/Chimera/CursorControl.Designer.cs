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
            this.cursorControl_Cancel = new System.Windows.Forms.Button();
            this.grpBox_Feature_Enable = new System.Windows.Forms.GroupBox();
            this.cb_FeatureEnable = new System.Windows.Forms.CheckBox();
            this.grpBox_EachFeatures = new System.Windows.Forms.GroupBox();
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
            this.btn_Cursor_Move_Primary_KeyChange = new System.Windows.Forms.Button();
            this.txtBox_Hotkey_MoveCurPrimary = new System.Windows.Forms.TextBox();
            this.cb_MovCursorPrimary = new System.Windows.Forms.CheckBox();
            this.grpBox_Feature_Enable.SuspendLayout();
            this.grpBox_EachFeatures.SuspendLayout();
            this.SuspendLayout();
            // 
            // cursorControl_Set
            // 
            this.cursorControl_Set.Location = new System.Drawing.Point(307, 405);
            this.cursorControl_Set.Name = "cursorControl_Set";
            this.cursorControl_Set.Size = new System.Drawing.Size(102, 34);
            this.cursorControl_Set.TabIndex = 0;
            this.cursorControl_Set.Text = "SET";
            this.cursorControl_Set.UseVisualStyleBackColor = true;
            this.cursorControl_Set.Click += new System.EventHandler(this.cursorControl_Set_click);
            // 
            // cursorControl_Cancel
            // 
            this.cursorControl_Cancel.Location = new System.Drawing.Point(415, 405);
            this.cursorControl_Cancel.Name = "cursorControl_Cancel";
            this.cursorControl_Cancel.Size = new System.Drawing.Size(102, 34);
            this.cursorControl_Cancel.TabIndex = 1;
            this.cursorControl_Cancel.Text = "CANCEL";
            this.cursorControl_Cancel.UseVisualStyleBackColor = true;
            this.cursorControl_Cancel.Click += new System.EventHandler(this.cursorControl_Cancel_click);
            // 
            // grpBox_Feature_Enable
            // 
            this.grpBox_Feature_Enable.Controls.Add(this.cb_FeatureEnable);
            this.grpBox_Feature_Enable.Location = new System.Drawing.Point(12, 12);
            this.grpBox_Feature_Enable.Name = "grpBox_Feature_Enable";
            this.grpBox_Feature_Enable.Size = new System.Drawing.Size(505, 52);
            this.grpBox_Feature_Enable.TabIndex = 2;
            this.grpBox_Feature_Enable.TabStop = false;
            this.grpBox_Feature_Enable.Text = "Feature Enable";
            // 
            // cb_FeatureEnable
            // 
            this.cb_FeatureEnable.AutoSize = true;
            this.cb_FeatureEnable.Location = new System.Drawing.Point(18, 20);
            this.cb_FeatureEnable.Name = "cb_FeatureEnable";
            this.cb_FeatureEnable.Size = new System.Drawing.Size(162, 16);
            this.cb_FeatureEnable.TabIndex = 0;
            this.cb_FeatureEnable.Text = " Enable Cursor Features";
            this.cb_FeatureEnable.UseVisualStyleBackColor = true;
            this.cb_FeatureEnable.CheckedChanged += new System.EventHandler(this.cb_FeatureEnable_ChangeCheck);
            // 
            // grpBox_EachFeatures
            // 
            this.grpBox_EachFeatures.Controls.Add(this.btn_Cursor_Move_Primary_KeyChange);
            this.grpBox_EachFeatures.Controls.Add(this.txtBox_Hotkey_MoveCurPrimary);
            this.grpBox_EachFeatures.Controls.Add(this.cb_MovCursorPrimary);
            this.grpBox_EachFeatures.Controls.Add(this.btn_Cursor_Lock_Screen_KeyChange);
            this.grpBox_EachFeatures.Controls.Add(this.txtBox_Hotkey_LockToScreen);
            this.grpBox_EachFeatures.Controls.Add(this.cb_LockToScreen);
            this.grpBox_EachFeatures.Controls.Add(this.btn_CursorMov_Prev_Screen_KeyChange);
            this.grpBox_EachFeatures.Controls.Add(this.txtBox_Hotkey_MovCurPrevScreen);
            this.grpBox_EachFeatures.Controls.Add(this.cb_MovCursorPrevScreen);
            this.grpBox_EachFeatures.Controls.Add(this.btn_CursorMov_Next_Screen_KeyChange);
            this.grpBox_EachFeatures.Controls.Add(this.txtBox_Hotkey_MovCurNextScreen);
            this.grpBox_EachFeatures.Controls.Add(this.cb_MovCursorNextScreen);
            this.grpBox_EachFeatures.Location = new System.Drawing.Point(12, 88);
            this.grpBox_EachFeatures.Name = "grpBox_EachFeatures";
            this.grpBox_EachFeatures.Size = new System.Drawing.Size(505, 219);
            this.grpBox_EachFeatures.TabIndex = 3;
            this.grpBox_EachFeatures.TabStop = false;
            this.grpBox_EachFeatures.Text = "Features";
            // 
            // btn_Cursor_Lock_Screen_KeyChange
            // 
            this.btn_Cursor_Lock_Screen_KeyChange.Location = new System.Drawing.Point(396, 147);
            this.btn_Cursor_Lock_Screen_KeyChange.Name = "btn_Cursor_Lock_Screen_KeyChange";
            this.btn_Cursor_Lock_Screen_KeyChange.Size = new System.Drawing.Size(95, 21);
            this.btn_Cursor_Lock_Screen_KeyChange.TabIndex = 10;
            this.btn_Cursor_Lock_Screen_KeyChange.Text = "Change...";
            this.btn_Cursor_Lock_Screen_KeyChange.UseVisualStyleBackColor = true;
            this.btn_Cursor_Lock_Screen_KeyChange.Click += new System.EventHandler(this.btn_Click_Cursor_Lock_Screen_KeyChange);
            // 
            // txtBox_Hotkey_LockToScreen
            // 
            this.txtBox_Hotkey_LockToScreen.Location = new System.Drawing.Point(237, 147);
            this.txtBox_Hotkey_LockToScreen.Name = "txtBox_Hotkey_LockToScreen";
            this.txtBox_Hotkey_LockToScreen.ReadOnly = true;
            this.txtBox_Hotkey_LockToScreen.Size = new System.Drawing.Size(153, 21);
            this.txtBox_Hotkey_LockToScreen.TabIndex = 9;
            this.txtBox_Hotkey_LockToScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_LockToScreen
            // 
            this.cb_LockToScreen.AutoSize = true;
            this.cb_LockToScreen.Location = new System.Drawing.Point(18, 151);
            this.cb_LockToScreen.Name = "cb_LockToScreen";
            this.cb_LockToScreen.Size = new System.Drawing.Size(170, 16);
            this.cb_LockToScreen.TabIndex = 8;
            this.cb_LockToScreen.Text = " Lock / Unlock To Screen";
            this.cb_LockToScreen.UseVisualStyleBackColor = true;
            this.cb_LockToScreen.CheckedChanged += new System.EventHandler(this.cb_LockScreen_ChangeCheck);
            // 
            // btn_CursorMov_Prev_Screen_KeyChange
            // 
            this.btn_CursorMov_Prev_Screen_KeyChange.Location = new System.Drawing.Point(396, 72);
            this.btn_CursorMov_Prev_Screen_KeyChange.Name = "btn_CursorMov_Prev_Screen_KeyChange";
            this.btn_CursorMov_Prev_Screen_KeyChange.Size = new System.Drawing.Size(95, 21);
            this.btn_CursorMov_Prev_Screen_KeyChange.TabIndex = 7;
            this.btn_CursorMov_Prev_Screen_KeyChange.Text = "Change...";
            this.btn_CursorMov_Prev_Screen_KeyChange.UseVisualStyleBackColor = true;
            this.btn_CursorMov_Prev_Screen_KeyChange.Click += new System.EventHandler(this.btn_Click_CursorMov_Prev_Screen_KeyChange);
            // 
            // txtBox_Hotkey_MovCurPrevScreen
            // 
            this.txtBox_Hotkey_MovCurPrevScreen.Location = new System.Drawing.Point(237, 72);
            this.txtBox_Hotkey_MovCurPrevScreen.Name = "txtBox_Hotkey_MovCurPrevScreen";
            this.txtBox_Hotkey_MovCurPrevScreen.ReadOnly = true;
            this.txtBox_Hotkey_MovCurPrevScreen.Size = new System.Drawing.Size(153, 21);
            this.txtBox_Hotkey_MovCurPrevScreen.TabIndex = 6;
            this.txtBox_Hotkey_MovCurPrevScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_MovCursorPrevScreen
            // 
            this.cb_MovCursorPrevScreen.AutoSize = true;
            this.cb_MovCursorPrevScreen.Location = new System.Drawing.Point(18, 76);
            this.cb_MovCursorPrevScreen.Name = "cb_MovCursorPrevScreen";
            this.cb_MovCursorPrevScreen.Size = new System.Drawing.Size(217, 16);
            this.cb_MovCursorPrevScreen.TabIndex = 5;
            this.cb_MovCursorPrevScreen.Text = " Move Cursor To Previous Screen";
            this.cb_MovCursorPrevScreen.UseVisualStyleBackColor = true;
            this.cb_MovCursorPrevScreen.CheckedChanged += new System.EventHandler(this.cb_CursorPrevScreen_ChangeCheck);
            // 
            // btn_CursorMov_Next_Screen_KeyChange
            // 
            this.btn_CursorMov_Next_Screen_KeyChange.Location = new System.Drawing.Point(396, 36);
            this.btn_CursorMov_Next_Screen_KeyChange.Name = "btn_CursorMov_Next_Screen_KeyChange";
            this.btn_CursorMov_Next_Screen_KeyChange.Size = new System.Drawing.Size(95, 21);
            this.btn_CursorMov_Next_Screen_KeyChange.TabIndex = 4;
            this.btn_CursorMov_Next_Screen_KeyChange.Text = "Change...";
            this.btn_CursorMov_Next_Screen_KeyChange.UseVisualStyleBackColor = true;
            this.btn_CursorMov_Next_Screen_KeyChange.Click += new System.EventHandler(this.btn_Click_CursorMov_Next_Screen_KeyChange);
            // 
            // txtBox_Hotkey_MovCurNextScreen
            // 
            this.txtBox_Hotkey_MovCurNextScreen.Location = new System.Drawing.Point(237, 36);
            this.txtBox_Hotkey_MovCurNextScreen.Name = "txtBox_Hotkey_MovCurNextScreen";
            this.txtBox_Hotkey_MovCurNextScreen.ReadOnly = true;
            this.txtBox_Hotkey_MovCurNextScreen.Size = new System.Drawing.Size(153, 21);
            this.txtBox_Hotkey_MovCurNextScreen.TabIndex = 1;
            this.txtBox_Hotkey_MovCurNextScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_MovCursorNextScreen
            // 
            this.cb_MovCursorNextScreen.AutoSize = true;
            this.cb_MovCursorNextScreen.Location = new System.Drawing.Point(18, 40);
            this.cb_MovCursorNextScreen.Name = "cb_MovCursorNextScreen";
            this.cb_MovCursorNextScreen.Size = new System.Drawing.Size(194, 16);
            this.cb_MovCursorNextScreen.TabIndex = 0;
            this.cb_MovCursorNextScreen.Text = " Move Cursor To Next Screen";
            this.cb_MovCursorNextScreen.UseVisualStyleBackColor = true;
            this.cb_MovCursorNextScreen.CheckedChanged += new System.EventHandler(this.cb_CursorNextScreen_ChangeCheck);
            // 
            // cursorControl_Reset
            // 
            this.cursorControl_Reset.Location = new System.Drawing.Point(12, 405);
            this.cursorControl_Reset.Name = "cursorControl_Reset";
            this.cursorControl_Reset.Size = new System.Drawing.Size(102, 34);
            this.cursorControl_Reset.TabIndex = 4;
            this.cursorControl_Reset.Text = "RESET";
            this.cursorControl_Reset.UseVisualStyleBackColor = true;
            this.cursorControl_Reset.Click += new System.EventHandler(this.cursorControl_Reset_Click);
            // 
            // btn_Cursor_Move_Primary_KeyChange
            // 
            this.btn_Cursor_Move_Primary_KeyChange.Location = new System.Drawing.Point(396, 109);
            this.btn_Cursor_Move_Primary_KeyChange.Name = "btn_Cursor_Move_Primary_KeyChange";
            this.btn_Cursor_Move_Primary_KeyChange.Size = new System.Drawing.Size(95, 21);
            this.btn_Cursor_Move_Primary_KeyChange.TabIndex = 13;
            this.btn_Cursor_Move_Primary_KeyChange.Text = "Change...";
            this.btn_Cursor_Move_Primary_KeyChange.UseVisualStyleBackColor = true;
            this.btn_Cursor_Move_Primary_KeyChange.MouseCaptureChanged += new System.EventHandler(this.btn_Click_CursorMov_Primary_Screen_KeyChange);
            // 
            // txtBox_Hotkey_MoveCurPrimary
            // 
            this.txtBox_Hotkey_MoveCurPrimary.Location = new System.Drawing.Point(237, 109);
            this.txtBox_Hotkey_MoveCurPrimary.Name = "txtBox_Hotkey_MoveCurPrimary";
            this.txtBox_Hotkey_MoveCurPrimary.ReadOnly = true;
            this.txtBox_Hotkey_MoveCurPrimary.Size = new System.Drawing.Size(153, 21);
            this.txtBox_Hotkey_MoveCurPrimary.TabIndex = 12;
            this.txtBox_Hotkey_MoveCurPrimary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_MovCursorPrimary
            // 
            this.cb_MovCursorPrimary.AutoSize = true;
            this.cb_MovCursorPrimary.Location = new System.Drawing.Point(18, 113);
            this.cb_MovCursorPrimary.Name = "cb_MovCursorPrimary";
            this.cb_MovCursorPrimary.Size = new System.Drawing.Size(212, 16);
            this.cb_MovCursorPrimary.TabIndex = 11;
            this.cb_MovCursorPrimary.Text = " Move Cursor To Primary Screen";
            this.cb_MovCursorPrimary.UseVisualStyleBackColor = true;
            this.cb_MovCursorPrimary.CheckedChanged += new System.EventHandler(this.cb_CursorPrimaryScreen_ChangeCheck);
            // 
            // CursorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 469);
            this.Controls.Add(this.cursorControl_Reset);
            this.Controls.Add(this.grpBox_EachFeatures);
            this.Controls.Add(this.grpBox_Feature_Enable);
            this.Controls.Add(this.cursorControl_Cancel);
            this.Controls.Add(this.cursorControl_Set);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CursorControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CursorControl";
            this.Shown += new System.EventHandler(this.ShownForm);
            this.grpBox_Feature_Enable.ResumeLayout(false);
            this.grpBox_Feature_Enable.PerformLayout();
            this.grpBox_EachFeatures.ResumeLayout(false);
            this.grpBox_EachFeatures.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cursorControl_Set;
        private System.Windows.Forms.Button cursorControl_Cancel;
        private System.Windows.Forms.GroupBox grpBox_Feature_Enable;
        private System.Windows.Forms.CheckBox cb_FeatureEnable;
        private System.Windows.Forms.GroupBox grpBox_EachFeatures;
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
    }
}