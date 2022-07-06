using System.Drawing;

namespace Chimera
{
    partial class BaseForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutBoxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upperSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cursorControlMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingWallpaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowerSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Moon";
            this.notifyIcon1.BalloonTipTitle = "MoonLight";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = global::Chimera.Properties.Resources.ApplicationName;
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutBoxMenuItem,
            this.upperSeparator,
            this.cursorControlMenuItem,
            this.manageToolStripMenuItem,
            this.SettingWallpaperToolStripMenuItem,
            this.lowerSeparator,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 126);
            // 
            // aboutBoxMenuItem
            // 
            this.aboutBoxMenuItem.Name = "aboutBoxMenuItem";
            this.aboutBoxMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutBoxMenuItem.Text = "About...";
            this.aboutBoxMenuItem.Click += new System.EventHandler(this.aboutBoxMenuItem_click);
            // 
            // upperSeparator
            // 
            this.upperSeparator.Name = "upperSeparator";
            this.upperSeparator.Size = new System.Drawing.Size(124, 6);
            // 
            // cursorControlMenuItem
            // 
            this.cursorControlMenuItem.Name = "cursorControlMenuItem";
            this.cursorControlMenuItem.Size = new System.Drawing.Size(127, 22);
            this.cursorControlMenuItem.Text = "Cursor";
            this.cursorControlMenuItem.Click += new System.EventHandler(this.cursorControlMenuItem_click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.ManageItemClick);
            // 
            // SettingWallpaperToolStripMenuItem
            // 
            this.SettingWallpaperToolStripMenuItem.Name = "SettingWallpaperToolStripMenuItem";
            this.SettingWallpaperToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.SettingWallpaperToolStripMenuItem.Text = "Wallpaper";
            this.SettingWallpaperToolStripMenuItem.Click += new System.EventHandler(this.settingWallpaper_Click);
            // 
            // lowerSeparator
            // 
            this.lowerSeparator.Name = "lowerSeparator";
            this.lowerSeparator.Size = new System.Drawing.Size(124, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "BaseForm";
            this.ShowInTaskbar = false;
            this.Text = "Multi Monitor Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

#endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

        private System.Windows.Forms.ToolStripMenuItem aboutBoxMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursorControlMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingWallpaperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator upperSeparator;
        private System.Windows.Forms.ToolStripSeparator lowerSeparator;
    }
}


