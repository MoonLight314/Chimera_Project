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
            this.tv_Monitor_List = new System.Windows.Forms.TreeView();
            this.label_Primary = new System.Windows.Forms.Label();
            this.label_ProductName = new System.Windows.Forms.Label();
            this.label_Resolution = new System.Windows.Forms.Label();
            this.label_BitPerPixel = new System.Windows.Forms.Label();
            this.label_Output = new System.Windows.Forms.Label();
            this.label_Rotation = new System.Windows.Forms.Label();
            this.textBox_Primary = new System.Windows.Forms.TextBox();
            this.textBox_Rotation = new System.Windows.Forms.TextBox();
            this.textBox_OutputTech = new System.Windows.Forms.TextBox();
            this.textBox_BitPerPixel = new System.Windows.Forms.TextBox();
            this.textBox_Resolution = new System.Windows.Forms.TextBox();
            this.textBox_FriendlyName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv_Monitor_List
            // 
            this.tv_Monitor_List.Location = new System.Drawing.Point(12, 12);
            this.tv_Monitor_List.Name = "tv_Monitor_List";
            this.tv_Monitor_List.Size = new System.Drawing.Size(203, 225);
            this.tv_Monitor_List.TabIndex = 0;
            this.tv_Monitor_List.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_NodeMouseClick);
            // 
            // label_Primary
            // 
            this.label_Primary.AutoSize = true;
            this.label_Primary.Location = new System.Drawing.Point(16, 35);
            this.label_Primary.Name = "label_Primary";
            this.label_Primary.Size = new System.Drawing.Size(49, 12);
            this.label_Primary.TabIndex = 1;
            this.label_Primary.Text = "Primary";
            // 
            // label_ProductName
            // 
            this.label_ProductName.AutoSize = true;
            this.label_ProductName.Location = new System.Drawing.Point(16, 65);
            this.label_ProductName.Name = "label_ProductName";
            this.label_ProductName.Size = new System.Drawing.Size(86, 12);
            this.label_ProductName.TabIndex = 2;
            this.label_ProductName.Text = "Product Name";
            // 
            // label_Resolution
            // 
            this.label_Resolution.AutoSize = true;
            this.label_Resolution.Location = new System.Drawing.Point(16, 95);
            this.label_Resolution.Name = "label_Resolution";
            this.label_Resolution.Size = new System.Drawing.Size(64, 12);
            this.label_Resolution.TabIndex = 3;
            this.label_Resolution.Text = "Resolution";
            // 
            // label_BitPerPixel
            // 
            this.label_BitPerPixel.AutoSize = true;
            this.label_BitPerPixel.Location = new System.Drawing.Point(16, 125);
            this.label_BitPerPixel.Name = "label_BitPerPixel";
            this.label_BitPerPixel.Size = new System.Drawing.Size(74, 12);
            this.label_BitPerPixel.TabIndex = 4;
            this.label_BitPerPixel.Text = "Bit Per Pixel";
            // 
            // label_Output
            // 
            this.label_Output.AutoSize = true;
            this.label_Output.Location = new System.Drawing.Point(16, 155);
            this.label_Output.Name = "label_Output";
            this.label_Output.Size = new System.Drawing.Size(41, 12);
            this.label_Output.TabIndex = 5;
            this.label_Output.Text = "Output";
            // 
            // label_Rotation
            // 
            this.label_Rotation.AutoSize = true;
            this.label_Rotation.Location = new System.Drawing.Point(16, 185);
            this.label_Rotation.Name = "label_Rotation";
            this.label_Rotation.Size = new System.Drawing.Size(50, 12);
            this.label_Rotation.TabIndex = 6;
            this.label_Rotation.Text = "Rotation";
            // 
            // textBox_Primary
            // 
            this.textBox_Primary.Location = new System.Drawing.Point(152, 29);
            this.textBox_Primary.Name = "textBox_Primary";
            this.textBox_Primary.ReadOnly = true;
            this.textBox_Primary.Size = new System.Drawing.Size(203, 21);
            this.textBox_Primary.TabIndex = 7;
            // 
            // textBox_Rotation
            // 
            this.textBox_Rotation.Location = new System.Drawing.Point(152, 182);
            this.textBox_Rotation.Name = "textBox_Rotation";
            this.textBox_Rotation.ReadOnly = true;
            this.textBox_Rotation.Size = new System.Drawing.Size(203, 21);
            this.textBox_Rotation.TabIndex = 8;
            // 
            // textBox_OutputTech
            // 
            this.textBox_OutputTech.Location = new System.Drawing.Point(152, 152);
            this.textBox_OutputTech.Name = "textBox_OutputTech";
            this.textBox_OutputTech.ReadOnly = true;
            this.textBox_OutputTech.Size = new System.Drawing.Size(203, 21);
            this.textBox_OutputTech.TabIndex = 9;
            // 
            // textBox_BitPerPixel
            // 
            this.textBox_BitPerPixel.Location = new System.Drawing.Point(152, 122);
            this.textBox_BitPerPixel.Name = "textBox_BitPerPixel";
            this.textBox_BitPerPixel.ReadOnly = true;
            this.textBox_BitPerPixel.Size = new System.Drawing.Size(203, 21);
            this.textBox_BitPerPixel.TabIndex = 10;
            // 
            // textBox_Resolution
            // 
            this.textBox_Resolution.Location = new System.Drawing.Point(152, 92);
            this.textBox_Resolution.Name = "textBox_Resolution";
            this.textBox_Resolution.ReadOnly = true;
            this.textBox_Resolution.Size = new System.Drawing.Size(203, 21);
            this.textBox_Resolution.TabIndex = 11;
            // 
            // textBox_FriendlyName
            // 
            this.textBox_FriendlyName.Location = new System.Drawing.Point(152, 62);
            this.textBox_FriendlyName.Name = "textBox_FriendlyName";
            this.textBox_FriendlyName.ReadOnly = true;
            this.textBox_FriendlyName.Size = new System.Drawing.Size(203, 21);
            this.textBox_FriendlyName.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_FriendlyName);
            this.groupBox1.Controls.Add(this.textBox_Resolution);
            this.groupBox1.Controls.Add(this.textBox_BitPerPixel);
            this.groupBox1.Controls.Add(this.textBox_OutputTech);
            this.groupBox1.Controls.Add(this.textBox_Rotation);
            this.groupBox1.Controls.Add(this.textBox_Primary);
            this.groupBox1.Controls.Add(this.label_Rotation);
            this.groupBox1.Controls.Add(this.label_Output);
            this.groupBox1.Controls.Add(this.label_BitPerPixel);
            this.groupBox1.Controls.Add(this.label_Resolution);
            this.groupBox1.Controls.Add(this.label_ProductName);
            this.groupBox1.Controls.Add(this.label_Primary);
            this.groupBox1.Location = new System.Drawing.Point(233, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 221);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(366, 330);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(111, 39);
            this.button_OK.TabIndex = 14;
            this.button_OK.Text = "SET";
            this.button_OK.UseVisualStyleBackColor = true;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(503, 330);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(111, 39);
            this.button_Exit.TabIndex = 15;
            this.button_Exit.Text = "EXIT";
            this.button_Exit.UseVisualStyleBackColor = true;
            // 
            // ManageMultiMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 391);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tv_Monitor_List);
            this.Name = "ManageMultiMonitor";
            this.Text = "ManageMultiMonitor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv_Monitor_List;
        private System.Windows.Forms.Label label_Primary;
        private System.Windows.Forms.Label label_ProductName;
        private System.Windows.Forms.Label label_Resolution;
        private System.Windows.Forms.Label label_BitPerPixel;
        private System.Windows.Forms.Label label_Output;
        private System.Windows.Forms.Label label_Rotation;
        private System.Windows.Forms.TextBox textBox_Primary;
        private System.Windows.Forms.TextBox textBox_Rotation;
        private System.Windows.Forms.TextBox textBox_OutputTech;
        private System.Windows.Forms.TextBox textBox_BitPerPixel;
        private System.Windows.Forms.TextBox textBox_Resolution;
        private System.Windows.Forms.TextBox textBox_FriendlyName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Exit;
    }
}