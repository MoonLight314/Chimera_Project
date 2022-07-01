using System.Windows.Forms;

namespace Chimera
{
    partial class HotKeyConfirm
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
            this.label_Setting_HotKey = new System.Windows.Forms.Label();
            this.label_Input_Hotkey = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_Set = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Setting_HotKey
            // 
            this.label_Setting_HotKey.AutoSize = true;
            this.label_Setting_HotKey.Location = new System.Drawing.Point(17, 0);
            this.label_Setting_HotKey.Name = "label_Setting_HotKey";
            this.label_Setting_HotKey.Size = new System.Drawing.Size(85, 12);
            this.label_Setting_HotKey.TabIndex = 0;
            this.label_Setting_HotKey.Text = "Setting Hotkey";
            // 
            // label_Input_Hotkey
            // 
            this.label_Input_Hotkey.AutoSize = true;
            this.label_Input_Hotkey.Location = new System.Drawing.Point(22, 31);
            this.label_Input_Hotkey.Name = "label_Input_Hotkey";
            this.label_Input_Hotkey.Size = new System.Drawing.Size(38, 12);
            this.label_Input_Hotkey.TabIndex = 1;
            this.label_Input_Hotkey.Text = "label2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Location = new System.Drawing.Point(0, 64);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(514, 126);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // button_Set
            // 
            this.button_Set.FlatAppearance.BorderSize = 0;
            this.button_Set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Set.Location = new System.Drawing.Point(22, 86);
            this.button_Set.Name = "button_Set";
            this.button_Set.Size = new System.Drawing.Size(196, 32);
            this.button_Set.TabIndex = 0;
            this.button_Set.TabStop = false;
            this.button_Set.Text = "Set";
            this.button_Set.UseVisualStyleBackColor = true;
            this.button_Set.Click += new System.EventHandler(this.button_Set_Click);
            this.button_Set.Enter += new System.EventHandler(this.button_Set_MouseEnter);
            this.button_Set.Leave += new System.EventHandler(this.button_Set_MouseLeave);
            this.button_Set.MouseEnter += new System.EventHandler(this.button_Set_MouseEnter);
            this.button_Set.MouseLeave += new System.EventHandler(this.button_Set_MouseLeave);
            // 
            // button_Cancel
            // 
            this.button_Cancel.FlatAppearance.BorderSize = 0;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Location = new System.Drawing.Point(231, 86);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(196, 32);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.TabStop = false;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            this.button_Cancel.Enter += new System.EventHandler(this.button_Cancel_MouseEnter);
            this.button_Cancel.Leave += new System.EventHandler(this.button_Cancel_MouseLeave);
            this.button_Cancel.MouseEnter += new System.EventHandler(this.button_Cancel_MouseEnter);
            this.button_Cancel.MouseLeave += new System.EventHandler(this.button_Cancel_MouseLeave);
            // 
            // HotKeyConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 141);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Set);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_Input_Hotkey);
            this.Controls.Add(this.label_Setting_HotKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HotKeyConfirm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Setting_HotKey;
        private System.Windows.Forms.Label label_Input_Hotkey;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_Set;
        private System.Windows.Forms.Button button_Cancel;
    }
}