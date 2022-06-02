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
            this.cursorControl_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cursorControl_OK
            // 
            this.cursorControl_OK.Location = new System.Drawing.Point(197, 226);
            this.cursorControl_OK.Name = "cursorControl_OK";
            this.cursorControl_OK.Size = new System.Drawing.Size(75, 23);
            this.cursorControl_OK.TabIndex = 0;
            this.cursorControl_OK.Text = "OK";
            this.cursorControl_OK.UseVisualStyleBackColor = true;
            this.cursorControl_OK.Click += new System.EventHandler(this.cursorControl_OK_click);
            // 
            // CursorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cursorControl_OK);
            this.Name = "CursorControl";
            this.Text = "CursorControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cursorControl_OK;
    }
}