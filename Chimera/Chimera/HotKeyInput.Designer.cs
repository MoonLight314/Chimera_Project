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
            this.txtBox_NormalKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CANCEL = new System.Windows.Forms.Button();
            this.label_Hotkey_Input = new System.Windows.Forms.Label();
            this.pb_CheckBox_Shift = new System.Windows.Forms.PictureBox();
            this.label_Shift = new System.Windows.Forms.Label();
            this.pb_CheckBox_Ctrl = new System.Windows.Forms.PictureBox();
            this.label_Ctrl = new System.Windows.Forms.Label();
            this.pb_CheckBox_Alt = new System.Windows.Forms.PictureBox();
            this.label_Alt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CheckBox_Shift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CheckBox_Ctrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CheckBox_Alt)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_NormalKey
            // 
            this.txtBox_NormalKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBox_NormalKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_NormalKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.txtBox_NormalKey.Location = new System.Drawing.Point(200, 114);
            this.txtBox_NormalKey.Name = "txtBox_NormalKey";
            this.txtBox_NormalKey.ReadOnly = true;
            this.txtBox_NormalKey.Size = new System.Drawing.Size(140, 14);
            this.txtBox_NormalKey.TabIndex = 3;
            this.txtBox_NormalKey.TabStop = false;
            this.txtBox_NormalKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_NormalKey.Enter += new System.EventHandler(this.txtBox_NormalKey_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(143, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "+";
            // 
            // btn_CANCEL
            // 
            this.btn_CANCEL.Location = new System.Drawing.Point(283, 200);
            this.btn_CANCEL.Name = "btn_CANCEL";
            this.btn_CANCEL.Size = new System.Drawing.Size(57, 22);
            this.btn_CANCEL.TabIndex = 5;
            this.btn_CANCEL.Text = "Reset";
            this.btn_CANCEL.UseVisualStyleBackColor = true;
            this.btn_CANCEL.Click += new System.EventHandler(this.HotKeyInput_Cancel);
            // 
            // label_Hotkey_Input
            // 
            this.label_Hotkey_Input.AutoSize = true;
            this.label_Hotkey_Input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label_Hotkey_Input.Location = new System.Drawing.Point(35, 40);
            this.label_Hotkey_Input.Name = "label_Hotkey_Input";
            this.label_Hotkey_Input.Size = new System.Drawing.Size(74, 12);
            this.label_Hotkey_Input.TabIndex = 15;
            this.label_Hotkey_Input.Text = "Hotkey Input";
            // 
            // pb_CheckBox_Shift
            // 
            this.pb_CheckBox_Shift.Location = new System.Drawing.Point(40, 77);
            this.pb_CheckBox_Shift.Name = "pb_CheckBox_Shift";
            this.pb_CheckBox_Shift.Size = new System.Drawing.Size(16, 16);
            this.pb_CheckBox_Shift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_CheckBox_Shift.TabIndex = 32;
            this.pb_CheckBox_Shift.TabStop = false;
            // 
            // label_Shift
            // 
            this.label_Shift.AutoSize = true;
            this.label_Shift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.label_Shift.Location = new System.Drawing.Point(59, 79);
            this.label_Shift.Name = "label_Shift";
            this.label_Shift.Size = new System.Drawing.Size(29, 12);
            this.label_Shift.TabIndex = 31;
            this.label_Shift.Text = "Shift";
            // 
            // pb_CheckBox_Ctrl
            // 
            this.pb_CheckBox_Ctrl.Location = new System.Drawing.Point(40, 113);
            this.pb_CheckBox_Ctrl.Name = "pb_CheckBox_Ctrl";
            this.pb_CheckBox_Ctrl.Size = new System.Drawing.Size(16, 16);
            this.pb_CheckBox_Ctrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_CheckBox_Ctrl.TabIndex = 34;
            this.pb_CheckBox_Ctrl.TabStop = false;
            // 
            // label_Ctrl
            // 
            this.label_Ctrl.AutoSize = true;
            this.label_Ctrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.label_Ctrl.Location = new System.Drawing.Point(59, 115);
            this.label_Ctrl.Name = "label_Ctrl";
            this.label_Ctrl.Size = new System.Drawing.Size(24, 12);
            this.label_Ctrl.TabIndex = 33;
            this.label_Ctrl.Text = "Ctrl";
            // 
            // pb_CheckBox_Alt
            // 
            this.pb_CheckBox_Alt.Location = new System.Drawing.Point(40, 149);
            this.pb_CheckBox_Alt.Name = "pb_CheckBox_Alt";
            this.pb_CheckBox_Alt.Size = new System.Drawing.Size(16, 16);
            this.pb_CheckBox_Alt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_CheckBox_Alt.TabIndex = 36;
            this.pb_CheckBox_Alt.TabStop = false;
            // 
            // label_Alt
            // 
            this.label_Alt.AutoSize = true;
            this.label_Alt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.label_Alt.Location = new System.Drawing.Point(59, 151);
            this.label_Alt.Name = "label_Alt";
            this.label_Alt.Size = new System.Drawing.Size(19, 12);
            this.label_Alt.TabIndex = 35;
            this.label_Alt.Text = "Alt";
            // 
            // HotKeyInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 271);
            this.Controls.Add(this.pb_CheckBox_Alt);
            this.Controls.Add(this.label_Alt);
            this.Controls.Add(this.pb_CheckBox_Ctrl);
            this.Controls.Add(this.label_Ctrl);
            this.Controls.Add(this.pb_CheckBox_Shift);
            this.Controls.Add(this.label_Shift);
            this.Controls.Add(this.label_Hotkey_Input);
            this.Controls.Add(this.btn_CANCEL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_NormalKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HotKeyInput";
            this.Opacity = 0.5D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_up);
            ((System.ComponentModel.ISupportInitialize)(this.pb_CheckBox_Shift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CheckBox_Ctrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CheckBox_Alt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        //private System.Windows.Forms.CheckBox cb_Shift;
        //private System.Windows.Forms.CheckBox cb_Ctrl;
        //private System.Windows.Forms.CheckBox cb_Alt;
        private System.Windows.Forms.TextBox txtBox_NormalKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CANCEL;
        private System.Windows.Forms.Label label_Hotkey_Input;
        private System.Windows.Forms.PictureBox pb_CheckBox_Shift;
        private System.Windows.Forms.Label label_Shift;
        private System.Windows.Forms.PictureBox pb_CheckBox_Ctrl;
        private System.Windows.Forms.Label label_Ctrl;
        private System.Windows.Forms.PictureBox pb_CheckBox_Alt;
        private System.Windows.Forms.Label label_Alt;
    }
}