namespace Chimera
{
    partial class WarningDuplicatedHotkey
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
            this.label_Message = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.pictureBox_Exclamation_Mark = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exclamation_Mark)).BeginInit();
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
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Location = new System.Drawing.Point(42, 31);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(184, 12);
            this.label_Message.TabIndex = 1;
            this.label_Message.Text = "This hotkey is already registed.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Location = new System.Drawing.Point(0, 64);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(318, 86);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // button_Close
            // 
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Location = new System.Drawing.Point(164, 89);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(132, 32);
            this.button_Close.TabIndex = 1;
            this.button_Close.TabStop = false;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            this.button_Close.Enter += new System.EventHandler(this.button_Close_Enter);
            this.button_Close.Leave += new System.EventHandler(this.button_Close_Leave);
            this.button_Close.MouseEnter += new System.EventHandler(this.button_Close_MouseEnter);
            this.button_Close.MouseLeave += new System.EventHandler(this.button_Close_MouseLeave);
            // 
            // pictureBox_Exclamation_Mark
            // 
            this.pictureBox_Exclamation_Mark.Image = global::Chimera.Properties.Resources.Exclamation_Mark;
            this.pictureBox_Exclamation_Mark.Location = new System.Drawing.Point(22, 29);
            this.pictureBox_Exclamation_Mark.Name = "pictureBox_Exclamation_Mark";
            this.pictureBox_Exclamation_Mark.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_Exclamation_Mark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Exclamation_Mark.TabIndex = 26;
            this.pictureBox_Exclamation_Mark.TabStop = false;
            // 
            // WarningDuplicatedHotkey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 144);
            this.Controls.Add(this.pictureBox_Exclamation_Mark);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.label_Setting_HotKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WarningDuplicatedHotkey";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exclamation_Mark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Setting_HotKey;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.PictureBox pictureBox_Exclamation_Mark;
    }
}