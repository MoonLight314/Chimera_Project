namespace Chimera
{
    partial class ManageMultiMonitor
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
            this.cb_SetAsPrimary = new System.Windows.Forms.CheckBox();
            this.trackBar_Brightness = new System.Windows.Forms.TrackBar();
            this.trackBar_Contrast = new System.Windows.Forms.TrackBar();
            this.label_Brightness = new System.Windows.Forms.Label();
            this.label_Contrast = new System.Windows.Forms.Label();
            this.label_Primary = new System.Windows.Forms.Label();
            this.label_Resolution = new System.Windows.Forms.Label();
            this.label_BitPerPixel = new System.Windows.Forms.Label();
            this.label_Output = new System.Windows.Forms.Label();
            this.label_Rotation = new System.Windows.Forms.Label();
            this.textBox_Primary = new System.Windows.Forms.TextBox();
            this.textBox_Rotation = new System.Windows.Forms.TextBox();
            this.textBox_OutputTech = new System.Windows.Forms.TextBox();
            this.textBox_BitPerPixel = new System.Windows.Forms.TextBox();
            this.textBox_Resolution = new System.Windows.Forms.TextBox();
            this.label_Multi_Monitor = new System.Windows.Forms.Label();
            this.lv_Monitors = new System.Windows.Forms.ListView();
            this.label_FriendlyName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_Setting = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_Current_Contrast_Value = new System.Windows.Forms.Label();
            this.label_Current_Brightness_Value = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label_Warning = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_SetAsPrimary
            // 
            this.cb_SetAsPrimary.AutoSize = true;
            this.cb_SetAsPrimary.Enabled = false;
            this.cb_SetAsPrimary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.cb_SetAsPrimary.Location = new System.Drawing.Point(311, 306);
            this.cb_SetAsPrimary.Name = "cb_SetAsPrimary";
            this.cb_SetAsPrimary.Size = new System.Drawing.Size(109, 16);
            this.cb_SetAsPrimary.TabIndex = 15;
            this.cb_SetAsPrimary.Text = "Set As Primary";
            this.cb_SetAsPrimary.UseVisualStyleBackColor = true;
            this.cb_SetAsPrimary.Click += new System.EventHandler(this.click_SetAsPrimary);
            // 
            // trackBar_Brightness
            // 
            this.trackBar_Brightness.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar_Brightness.Location = new System.Drawing.Point(434, 372);
            this.trackBar_Brightness.Maximum = 100;
            this.trackBar_Brightness.Name = "trackBar_Brightness";
            this.trackBar_Brightness.Size = new System.Drawing.Size(200, 45);
            this.trackBar_Brightness.TabIndex = 17;
            this.trackBar_Brightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_Brightness.Scroll += new System.EventHandler(this.trackBar_Brightness_Scroll);
            // 
            // trackBar_Contrast
            // 
            this.trackBar_Contrast.Location = new System.Drawing.Point(434, 412);
            this.trackBar_Contrast.Maximum = 100;
            this.trackBar_Contrast.Name = "trackBar_Contrast";
            this.trackBar_Contrast.Size = new System.Drawing.Size(200, 45);
            this.trackBar_Contrast.TabIndex = 18;
            this.trackBar_Contrast.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_Contrast.Scroll += new System.EventHandler(this.trackBar_Contrast_Scroll);
            // 
            // label_Brightness
            // 
            this.label_Brightness.AutoSize = true;
            this.label_Brightness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label_Brightness.Location = new System.Drawing.Point(304, 374);
            this.label_Brightness.Name = "label_Brightness";
            this.label_Brightness.Size = new System.Drawing.Size(65, 12);
            this.label_Brightness.TabIndex = 13;
            this.label_Brightness.Text = "Brightness";
            // 
            // label_Contrast
            // 
            this.label_Contrast.AutoSize = true;
            this.label_Contrast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label_Contrast.Location = new System.Drawing.Point(304, 414);
            this.label_Contrast.Name = "label_Contrast";
            this.label_Contrast.Size = new System.Drawing.Size(52, 12);
            this.label_Contrast.TabIndex = 19;
            this.label_Contrast.Text = "Contrast";
            // 
            // label_Primary
            // 
            this.label_Primary.AutoSize = true;
            this.label_Primary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label_Primary.Location = new System.Drawing.Point(304, 109);
            this.label_Primary.Name = "label_Primary";
            this.label_Primary.Size = new System.Drawing.Size(49, 12);
            this.label_Primary.TabIndex = 1;
            this.label_Primary.Text = "Primary";
            // 
            // label_Resolution
            // 
            this.label_Resolution.AutoSize = true;
            this.label_Resolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label_Resolution.Location = new System.Drawing.Point(304, 132);
            this.label_Resolution.Name = "label_Resolution";
            this.label_Resolution.Size = new System.Drawing.Size(64, 12);
            this.label_Resolution.TabIndex = 3;
            this.label_Resolution.Text = "Resolution";
            // 
            // label_BitPerPixel
            // 
            this.label_BitPerPixel.AutoSize = true;
            this.label_BitPerPixel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_BitPerPixel.Location = new System.Drawing.Point(304, 155);
            this.label_BitPerPixel.Name = "label_BitPerPixel";
            this.label_BitPerPixel.Size = new System.Drawing.Size(29, 12);
            this.label_BitPerPixel.TabIndex = 4;
            this.label_BitPerPixel.Text = "BPP";
            // 
            // label_Output
            // 
            this.label_Output.AutoSize = true;
            this.label_Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label_Output.Location = new System.Drawing.Point(304, 178);
            this.label_Output.Name = "label_Output";
            this.label_Output.Size = new System.Drawing.Size(41, 12);
            this.label_Output.TabIndex = 5;
            this.label_Output.Text = "Output";
            // 
            // label_Rotation
            // 
            this.label_Rotation.AutoSize = true;
            this.label_Rotation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label_Rotation.Location = new System.Drawing.Point(304, 201);
            this.label_Rotation.Name = "label_Rotation";
            this.label_Rotation.Size = new System.Drawing.Size(50, 12);
            this.label_Rotation.TabIndex = 6;
            this.label_Rotation.Text = "Rotation";
            // 
            // textBox_Primary
            // 
            this.textBox_Primary.BackColor = System.Drawing.Color.White;
            this.textBox_Primary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Primary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.textBox_Primary.Location = new System.Drawing.Point(434, 109);
            this.textBox_Primary.Name = "textBox_Primary";
            this.textBox_Primary.ReadOnly = true;
            this.textBox_Primary.Size = new System.Drawing.Size(203, 14);
            this.textBox_Primary.TabIndex = 7;
            this.textBox_Primary.Enter += new System.EventHandler(this.textBox_Primary_Enter);
            // 
            // textBox_Rotation
            // 
            this.textBox_Rotation.BackColor = System.Drawing.Color.White;
            this.textBox_Rotation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Rotation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.textBox_Rotation.Location = new System.Drawing.Point(434, 201);
            this.textBox_Rotation.Name = "textBox_Rotation";
            this.textBox_Rotation.ReadOnly = true;
            this.textBox_Rotation.Size = new System.Drawing.Size(203, 14);
            this.textBox_Rotation.TabIndex = 8;
            this.textBox_Rotation.Enter += new System.EventHandler(this.textBox_Rotation_Enter);
            // 
            // textBox_OutputTech
            // 
            this.textBox_OutputTech.BackColor = System.Drawing.Color.White;
            this.textBox_OutputTech.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_OutputTech.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.textBox_OutputTech.Location = new System.Drawing.Point(434, 178);
            this.textBox_OutputTech.Name = "textBox_OutputTech";
            this.textBox_OutputTech.ReadOnly = true;
            this.textBox_OutputTech.Size = new System.Drawing.Size(203, 14);
            this.textBox_OutputTech.TabIndex = 9;
            this.textBox_OutputTech.Enter += new System.EventHandler(this.textBox_OutputTech_Enter);
            // 
            // textBox_BitPerPixel
            // 
            this.textBox_BitPerPixel.BackColor = System.Drawing.Color.White;
            this.textBox_BitPerPixel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_BitPerPixel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.textBox_BitPerPixel.Location = new System.Drawing.Point(434, 155);
            this.textBox_BitPerPixel.Name = "textBox_BitPerPixel";
            this.textBox_BitPerPixel.ReadOnly = true;
            this.textBox_BitPerPixel.Size = new System.Drawing.Size(203, 14);
            this.textBox_BitPerPixel.TabIndex = 10;
            this.textBox_BitPerPixel.Enter += new System.EventHandler(this.textBox_BitPerPixel_Enter);
            // 
            // textBox_Resolution
            // 
            this.textBox_Resolution.BackColor = System.Drawing.Color.White;
            this.textBox_Resolution.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Resolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.textBox_Resolution.Location = new System.Drawing.Point(434, 132);
            this.textBox_Resolution.Name = "textBox_Resolution";
            this.textBox_Resolution.ReadOnly = true;
            this.textBox_Resolution.Size = new System.Drawing.Size(203, 14);
            this.textBox_Resolution.TabIndex = 11;
            this.textBox_Resolution.Enter += new System.EventHandler(this.textBox_Resolution_Enter);
            // 
            // label_Multi_Monitor
            // 
            this.label_Multi_Monitor.AutoSize = true;
            this.label_Multi_Monitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label_Multi_Monitor.Location = new System.Drawing.Point(33, 45);
            this.label_Multi_Monitor.Name = "label_Multi_Monitor";
            this.label_Multi_Monitor.Size = new System.Drawing.Size(80, 12);
            this.label_Multi_Monitor.TabIndex = 20;
            this.label_Multi_Monitor.Text = "Multi-Monitor";
            // 
            // lv_Monitors
            // 
            this.lv_Monitors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Monitors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_Monitors.Location = new System.Drawing.Point(24, 93);
            this.lv_Monitors.MultiSelect = false;
            this.lv_Monitors.Name = "lv_Monitors";
            this.lv_Monitors.Scrollable = false;
            this.lv_Monitors.Size = new System.Drawing.Size(245, 324);
            this.lv_Monitors.TabIndex = 22;
            this.lv_Monitors.UseCompatibleStateImageBehavior = false;
            this.lv_Monitors.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.lv_Monitors.Leave += new System.EventHandler(this.lv_Monitors_Leave);
            // 
            // label_FriendlyName
            // 
            this.label_FriendlyName.AutoSize = true;
            this.label_FriendlyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label_FriendlyName.Location = new System.Drawing.Point(304, 42);
            this.label_FriendlyName.Name = "label_FriendlyName";
            this.label_FriendlyName.Size = new System.Drawing.Size(88, 12);
            this.label_FriendlyName.TabIndex = 23;
            this.label_FriendlyName.Text = "Friendly Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pictureBox2.Location = new System.Drawing.Point(304, 243);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(428, 2);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label_Setting
            // 
            this.label_Setting.AutoSize = true;
            this.label_Setting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label_Setting.Location = new System.Drawing.Point(304, 268);
            this.label_Setting.Name = "label_Setting";
            this.label_Setting.Size = new System.Drawing.Size(43, 12);
            this.label_Setting.TabIndex = 25;
            this.label_Setting.Text = "Setting";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pictureBox3.Location = new System.Drawing.Point(304, 349);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(428, 3);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // label_Current_Contrast_Value
            // 
            this.label_Current_Contrast_Value.AutoSize = true;
            this.label_Current_Contrast_Value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_Current_Contrast_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.label_Current_Contrast_Value.Location = new System.Drawing.Point(672, 414);
            this.label_Current_Contrast_Value.Name = "label_Current_Contrast_Value";
            this.label_Current_Contrast_Value.Size = new System.Drawing.Size(52, 12);
            this.label_Current_Contrast_Value.TabIndex = 27;
            this.label_Current_Contrast_Value.Text = "Contrast";
            // 
            // label_Current_Brightness_Value
            // 
            this.label_Current_Brightness_Value.AutoSize = true;
            this.label_Current_Brightness_Value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_Current_Brightness_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.label_Current_Brightness_Value.Location = new System.Drawing.Point(672, 374);
            this.label_Current_Brightness_Value.Name = "label_Current_Brightness_Value";
            this.label_Current_Brightness_Value.Size = new System.Drawing.Size(65, 12);
            this.label_Current_Brightness_Value.TabIndex = 26;
            this.label_Current_Brightness_Value.Text = "Brightness";
            this.label_Current_Brightness_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pictureBox1.Location = new System.Drawing.Point(272, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 2);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pictureBox4.Location = new System.Drawing.Point(272, 6);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(2, 506);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // label_Warning
            // 
            this.label_Warning.AutoSize = true;
            this.label_Warning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.label_Warning.Location = new System.Drawing.Point(304, 460);
            this.label_Warning.Name = "label_Warning";
            this.label_Warning.Size = new System.Drawing.Size(448, 12);
            this.label_Warning.TabIndex = 30;
            this.label_Warning.Text = "This function might not be applicable depending on the capabilities of monitor.";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Chimera.Properties.Resources.Exclamation_Mark;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(288, 458);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(16, 16);
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // ManageMultiMonitor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 506);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label_Warning);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Current_Contrast_Value);
            this.Controls.Add(this.label_Current_Brightness_Value);
            this.Controls.Add(this.label_Setting);
            this.Controls.Add(this.label_FriendlyName);
            this.Controls.Add(this.lv_Monitors);
            this.Controls.Add(this.label_Multi_Monitor);
            this.Controls.Add(this.label_Contrast);
            this.Controls.Add(this.label_Brightness);
            this.Controls.Add(this.trackBar_Contrast);
            this.Controls.Add(this.trackBar_Brightness);
            this.Controls.Add(this.cb_SetAsPrimary);
            this.Controls.Add(this.textBox_Resolution);
            this.Controls.Add(this.textBox_BitPerPixel);
            this.Controls.Add(this.textBox_OutputTech);
            this.Controls.Add(this.textBox_Rotation);
            this.Controls.Add(this.textBox_Primary);
            this.Controls.Add(this.label_Rotation);
            this.Controls.Add(this.label_Output);
            this.Controls.Add(this.label_BitPerPixel);
            this.Controls.Add(this.label_Resolution);
            this.Controls.Add(this.label_Primary);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageMultiMonitor";
            this.Opacity = 0.94D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "LG USB-Hub Manager";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        //private System.Windows.Forms.TreeView tv_Monitor_List;
        //private System.Windows.Forms.Button button_OK;
        //private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.CheckBox cb_SetAsPrimary;
        private System.Windows.Forms.TrackBar trackBar_Brightness;
        private System.Windows.Forms.TrackBar trackBar_Contrast;
        private System.Windows.Forms.Label label_Brightness;
        private System.Windows.Forms.Label label_Contrast;
        private System.Windows.Forms.Label label_Primary;
        //private System.Windows.Forms.Label label_ProductName;
        private System.Windows.Forms.Label label_Resolution;
        private System.Windows.Forms.Label label_BitPerPixel;
        private System.Windows.Forms.Label label_Output;
        private System.Windows.Forms.Label label_Rotation;
        private System.Windows.Forms.TextBox textBox_Primary;
        private System.Windows.Forms.TextBox textBox_Rotation;
        private System.Windows.Forms.TextBox textBox_OutputTech;
        private System.Windows.Forms.TextBox textBox_BitPerPixel;
        private System.Windows.Forms.TextBox textBox_Resolution;
        //private System.Windows.Forms.TextBox textBox_FriendlyName;
        private System.Windows.Forms.Label label_Multi_Monitor;
        private System.Windows.Forms.ListView lv_Monitors;
        private System.Windows.Forms.Label label_FriendlyName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_Setting;
        private System.Windows.Forms.Label label_Current_Contrast_Value;
        private System.Windows.Forms.Label label_Current_Brightness_Value;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label_Warning;
        private System.Windows.Forms.PictureBox pictureBox5;

#if SUPPORT_MONITOR_OFF_FEATURE
        private System.Windows.Forms.CheckBox cb_MonitorOff;
#endif
    }
}