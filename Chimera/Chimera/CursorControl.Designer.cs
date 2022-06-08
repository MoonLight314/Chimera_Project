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
            this.cb_MovCursorNextScreen = new System.Windows.Forms.CheckBox();
            this.txtBox_Hotkey_MovCurNextScreen = new System.Windows.Forms.TextBox();
            this.btn_CursorMov_Next_Screen_KeyChange = new System.Windows.Forms.Button();
            this.btn_CursorMov_Prev_Screen_KeyChange = new System.Windows.Forms.Button();
            this.txtBox_Hotkey_MovCurPrevScreen = new System.Windows.Forms.TextBox();
            this.cb_MovCursorPrevScreen = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBox_Hotkey_StickToScreen = new System.Windows.Forms.TextBox();
            this.cb_StickToScreen = new System.Windows.Forms.CheckBox();
            this.grpBox_Feature_Enable.SuspendLayout();
            this.grpBox_EachFeatures.SuspendLayout();
            this.SuspendLayout();
            // 
            // cursorControl_Set
            // 
            this.cursorControl_Set.Location = new System.Drawing.Point(307, 304);
            this.cursorControl_Set.Name = "cursorControl_Set";
            this.cursorControl_Set.Size = new System.Drawing.Size(102, 34);
            this.cursorControl_Set.TabIndex = 0;
            this.cursorControl_Set.Text = "SET";
            this.cursorControl_Set.UseVisualStyleBackColor = true;
            this.cursorControl_Set.Click += new System.EventHandler(this.cursorControl_Set_click);
            // 
            // cursorControl_Cancel
            // 
            this.cursorControl_Cancel.Location = new System.Drawing.Point(415, 304);
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
            // 
            // grpBox_EachFeatures
            // 
            this.grpBox_EachFeatures.Controls.Add(this.button1);
            this.grpBox_EachFeatures.Controls.Add(this.txtBox_Hotkey_StickToScreen);
            this.grpBox_EachFeatures.Controls.Add(this.cb_StickToScreen);
            this.grpBox_EachFeatures.Controls.Add(this.btn_CursorMov_Prev_Screen_KeyChange);
            this.grpBox_EachFeatures.Controls.Add(this.txtBox_Hotkey_MovCurPrevScreen);
            this.grpBox_EachFeatures.Controls.Add(this.cb_MovCursorPrevScreen);
            this.grpBox_EachFeatures.Controls.Add(this.btn_CursorMov_Next_Screen_KeyChange);
            this.grpBox_EachFeatures.Controls.Add(this.txtBox_Hotkey_MovCurNextScreen);
            this.grpBox_EachFeatures.Controls.Add(this.cb_MovCursorNextScreen);
            this.grpBox_EachFeatures.Location = new System.Drawing.Point(12, 88);
            this.grpBox_EachFeatures.Name = "grpBox_EachFeatures";
            this.grpBox_EachFeatures.Size = new System.Drawing.Size(505, 191);
            this.grpBox_EachFeatures.TabIndex = 3;
            this.grpBox_EachFeatures.TabStop = false;
            this.grpBox_EachFeatures.Text = "Features";
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
            // 
            // txtBox_Hotkey_MovCurNextScreen
            // 
            this.txtBox_Hotkey_MovCurNextScreen.Location = new System.Drawing.Point(262, 36);
            this.txtBox_Hotkey_MovCurNextScreen.Name = "txtBox_Hotkey_MovCurNextScreen";
            this.txtBox_Hotkey_MovCurNextScreen.ReadOnly = true;
            this.txtBox_Hotkey_MovCurNextScreen.Size = new System.Drawing.Size(128, 21);
            this.txtBox_Hotkey_MovCurNextScreen.TabIndex = 1;
            // 
            // btn_CursorMov_Next_Screen_KeyChange
            // 
            this.btn_CursorMov_Next_Screen_KeyChange.Location = new System.Drawing.Point(396, 36);
            this.btn_CursorMov_Next_Screen_KeyChange.Name = "btn_CursorMov_Next_Screen_KeyChange";
            this.btn_CursorMov_Next_Screen_KeyChange.Size = new System.Drawing.Size(95, 21);
            this.btn_CursorMov_Next_Screen_KeyChange.TabIndex = 4;
            this.btn_CursorMov_Next_Screen_KeyChange.Text = "Change...";
            this.btn_CursorMov_Next_Screen_KeyChange.UseVisualStyleBackColor = true;
            // 
            // btn_CursorMov_Prev_Screen_KeyChange
            // 
            this.btn_CursorMov_Prev_Screen_KeyChange.Location = new System.Drawing.Point(396, 72);
            this.btn_CursorMov_Prev_Screen_KeyChange.Name = "btn_CursorMov_Prev_Screen_KeyChange";
            this.btn_CursorMov_Prev_Screen_KeyChange.Size = new System.Drawing.Size(95, 21);
            this.btn_CursorMov_Prev_Screen_KeyChange.TabIndex = 7;
            this.btn_CursorMov_Prev_Screen_KeyChange.Text = "Change...";
            this.btn_CursorMov_Prev_Screen_KeyChange.UseVisualStyleBackColor = true;
            // 
            // txtBox_Hotkey_MovCurPrevScreen
            // 
            this.txtBox_Hotkey_MovCurPrevScreen.Location = new System.Drawing.Point(262, 72);
            this.txtBox_Hotkey_MovCurPrevScreen.Name = "txtBox_Hotkey_MovCurPrevScreen";
            this.txtBox_Hotkey_MovCurPrevScreen.ReadOnly = true;
            this.txtBox_Hotkey_MovCurPrevScreen.Size = new System.Drawing.Size(128, 21);
            this.txtBox_Hotkey_MovCurPrevScreen.TabIndex = 6;
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
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 21);
            this.button1.TabIndex = 10;
            this.button1.Text = "Change...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBox_Hotkey_StickToScreen
            // 
            this.txtBox_Hotkey_StickToScreen.Location = new System.Drawing.Point(262, 108);
            this.txtBox_Hotkey_StickToScreen.Name = "txtBox_Hotkey_StickToScreen";
            this.txtBox_Hotkey_StickToScreen.ReadOnly = true;
            this.txtBox_Hotkey_StickToScreen.Size = new System.Drawing.Size(128, 21);
            this.txtBox_Hotkey_StickToScreen.TabIndex = 9;
            // 
            // cb_StickToScreen
            // 
            this.cb_StickToScreen.AutoSize = true;
            this.cb_StickToScreen.Location = new System.Drawing.Point(18, 112);
            this.cb_StickToScreen.Name = "cb_StickToScreen";
            this.cb_StickToScreen.Size = new System.Drawing.Size(118, 16);
            this.cb_StickToScreen.TabIndex = 8;
            this.cb_StickToScreen.Text = " Stick To Screen";
            this.cb_StickToScreen.UseVisualStyleBackColor = true;
            // 
            // CursorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 356);
            this.Controls.Add(this.grpBox_EachFeatures);
            this.Controls.Add(this.grpBox_Feature_Enable);
            this.Controls.Add(this.cursorControl_Cancel);
            this.Controls.Add(this.cursorControl_Set);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CursorControl";
            this.Text = "CursorControl";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBox_Hotkey_StickToScreen;
        private System.Windows.Forms.CheckBox cb_StickToScreen;
    }
}