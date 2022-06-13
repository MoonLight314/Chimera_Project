namespace Chimera
{
    partial class HotKeyInput
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
            this.cb_Shift = new System.Windows.Forms.CheckBox();
            this.cb_Ctrl = new System.Windows.Forms.CheckBox();
            this.cb_Alt = new System.Windows.Forms.CheckBox();
            this.txtBox_NormalKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CANCEL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Shift
            // 
            this.cb_Shift.AutoSize = true;
            this.cb_Shift.Location = new System.Drawing.Point(28, 22);
            this.cb_Shift.Name = "cb_Shift";
            this.cb_Shift.Size = new System.Drawing.Size(48, 16);
            this.cb_Shift.TabIndex = 0;
            this.cb_Shift.Text = "Shift";
            this.cb_Shift.UseVisualStyleBackColor = true;
            // 
            // cb_Ctrl
            // 
            this.cb_Ctrl.AutoSize = true;
            this.cb_Ctrl.Location = new System.Drawing.Point(28, 60);
            this.cb_Ctrl.Name = "cb_Ctrl";
            this.cb_Ctrl.Size = new System.Drawing.Size(43, 16);
            this.cb_Ctrl.TabIndex = 1;
            this.cb_Ctrl.Text = "Ctrl";
            this.cb_Ctrl.UseVisualStyleBackColor = true;
            // 
            // cb_Alt
            // 
            this.cb_Alt.AutoSize = true;
            this.cb_Alt.Location = new System.Drawing.Point(28, 97);
            this.cb_Alt.Name = "cb_Alt";
            this.cb_Alt.Size = new System.Drawing.Size(38, 16);
            this.cb_Alt.TabIndex = 2;
            this.cb_Alt.Text = "Alt";
            this.cb_Alt.UseVisualStyleBackColor = true;
            // 
            // txtBox_NormalKey
            // 
            this.txtBox_NormalKey.Location = new System.Drawing.Point(126, 55);
            this.txtBox_NormalKey.Name = "txtBox_NormalKey";
            this.txtBox_NormalKey.Size = new System.Drawing.Size(87, 21);
            this.txtBox_NormalKey.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "+";
            // 
            // btn_CANCEL
            // 
            this.btn_CANCEL.Location = new System.Drawing.Point(187, 133);
            this.btn_CANCEL.Name = "btn_CANCEL";
            this.btn_CANCEL.Size = new System.Drawing.Size(93, 39);
            this.btn_CANCEL.TabIndex = 5;
            this.btn_CANCEL.Text = "CANCEL";
            this.btn_CANCEL.UseVisualStyleBackColor = true;
            this.btn_CANCEL.Click += new System.EventHandler(this.HotKeyInput_Cancel);
            // 
            // HotKeyInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 185);
            this.Controls.Add(this.btn_CANCEL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_NormalKey);
            this.Controls.Add(this.cb_Alt);
            this.Controls.Add(this.cb_Ctrl);
            this.Controls.Add(this.cb_Shift);
            this.KeyPreview = true;
            this.Name = "HotKeyInput";
            this.Text = "HotKeyInput";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_test);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_up_test);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_Shift;
        private System.Windows.Forms.CheckBox cb_Ctrl;
        private System.Windows.Forms.CheckBox cb_Alt;
        private System.Windows.Forms.TextBox txtBox_NormalKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CANCEL;
    }
}