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
            this.aboutBox_OK = new System.Windows.Forms.Button();
            this.cb_Ctrl = new System.Windows.Forms.CheckBox();
            this.cb_Alt = new System.Windows.Forms.CheckBox();
            this.cb_Shift = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // aboutBox_OK
            // 
            this.aboutBox_OK.Location = new System.Drawing.Point(347, 293);
            this.aboutBox_OK.Name = "aboutBox_OK";
            this.aboutBox_OK.Size = new System.Drawing.Size(75, 23);
            this.aboutBox_OK.TabIndex = 0;
            this.aboutBox_OK.Text = "OK";
            this.aboutBox_OK.UseVisualStyleBackColor = true;
            this.aboutBox_OK.Click += new System.EventHandler(this.aboutBox_OK_click);
            // 
            // cb_Ctrl
            // 
            this.cb_Ctrl.AutoSize = true;
            this.cb_Ctrl.Location = new System.Drawing.Point(38, 46);
            this.cb_Ctrl.Name = "cb_Ctrl";
            this.cb_Ctrl.Size = new System.Drawing.Size(43, 16);
            this.cb_Ctrl.TabIndex = 1;
            this.cb_Ctrl.Text = "Ctrl";
            this.cb_Ctrl.UseVisualStyleBackColor = true;
            // 
            // cb_Alt
            // 
            this.cb_Alt.AutoSize = true;
            this.cb_Alt.Location = new System.Drawing.Point(38, 80);
            this.cb_Alt.Name = "cb_Alt";
            this.cb_Alt.Size = new System.Drawing.Size(38, 16);
            this.cb_Alt.TabIndex = 2;
            this.cb_Alt.Text = "Alt";
            this.cb_Alt.UseVisualStyleBackColor = true;
            // 
            // cb_Shift
            // 
            this.cb_Shift.AutoSize = true;
            this.cb_Shift.Location = new System.Drawing.Point(38, 115);
            this.cb_Shift.Name = "cb_Shift";
            this.cb_Shift.Size = new System.Drawing.Size(48, 16);
            this.cb_Shift.TabIndex = 3;
            this.cb_Shift.Text = "Shift";
            this.cb_Shift.UseVisualStyleBackColor = true;
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 328);
            this.Controls.Add(this.cb_Shift);
            this.Controls.Add(this.cb_Alt);
            this.Controls.Add(this.cb_Ctrl);
            this.Controls.Add(this.aboutBox_OK);
            this.KeyPreview = true;
            this.Name = "AboutBox";
            this.Text = "AboutBox";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_test);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_up_test);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aboutBox_OK;
        private System.Windows.Forms.CheckBox cb_Ctrl;
        private System.Windows.Forms.CheckBox cb_Alt;
        private System.Windows.Forms.CheckBox cb_Shift;
    }
}