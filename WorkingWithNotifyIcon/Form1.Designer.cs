namespace WorkingWithNotifyIcon
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chkTrayExit = new System.Windows.Forms.CheckBox();
            this.btnMinimizeToTray = new System.Windows.Forms.Button();
            this.btnShowBalloon = new System.Windows.Forms.Button();
            this.cmsiShow = new System.Windows.Forms.ToolStripTextBox();
            this.cmsiExit = new System.Windows.Forms.ToolStripTextBox();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Your computer is about to explode";
            this.notifyIcon.BalloonTipTitle = "Just so you know...";
            this.notifyIcon.ContextMenuStrip = this.cmsNotify;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Application name";
            this.notifyIcon.BalloonTipClosed += new System.EventHandler(this.notifyIcon_BalloonTipClosed);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // cmsNotify
            // 
            this.cmsNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cmsNotify.Name = "cmsNotify";
            this.cmsNotify.Size = new System.Drawing.Size(181, 70);
            // 
            // chkTrayExit
            // 
            this.chkTrayExit.AutoSize = true;
            this.chkTrayExit.Location = new System.Drawing.Point(12, 12);
            this.chkTrayExit.Name = "chkTrayExit";
            this.chkTrayExit.Size = new System.Drawing.Size(173, 17);
            this.chkTrayExit.TabIndex = 0;
            this.chkTrayExit.Text = "Minimize To Tray When Closed";
            this.chkTrayExit.UseVisualStyleBackColor = true;
            // 
            // btnMinimizeToTray
            // 
            this.btnMinimizeToTray.Location = new System.Drawing.Point(357, 229);
            this.btnMinimizeToTray.Name = "btnMinimizeToTray";
            this.btnMinimizeToTray.Size = new System.Drawing.Size(133, 23);
            this.btnMinimizeToTray.TabIndex = 1;
            this.btnMinimizeToTray.Text = "Minimize To Tray";
            this.btnMinimizeToTray.UseVisualStyleBackColor = true;
            this.btnMinimizeToTray.Click += new System.EventHandler(this.btnMinimizeToTray_Click);
            // 
            // btnShowBalloon
            // 
            this.btnShowBalloon.Location = new System.Drawing.Point(218, 229);
            this.btnShowBalloon.Name = "btnShowBalloon";
            this.btnShowBalloon.Size = new System.Drawing.Size(133, 23);
            this.btnShowBalloon.TabIndex = 2;
            this.btnShowBalloon.Text = "Show Balloon Tip";
            this.btnShowBalloon.UseVisualStyleBackColor = true;
            this.btnShowBalloon.Click += new System.EventHandler(this.btnShowBalloon_Click);
            // 
            // cmsiShow
            // 
            this.cmsiShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsiShow.Name = "cmsiShow";
            this.cmsiShow.Size = new System.Drawing.Size(100, 23);
            this.cmsiShow.Text = "Show";
            this.cmsiShow.Click += new System.EventHandler(this.cmsiShow_Click);
            // 
            // cmsiExit
            // 
            this.cmsiExit.AccessibleName = "Exit";
            this.cmsiExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsiExit.Name = "cmsiExit";
            this.cmsiExit.Size = new System.Drawing.Size(100, 23);
            this.cmsiExit.Text = "Exit";
            this.cmsiExit.Click += new System.EventHandler(this.cmsiExit_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 264);
            this.Controls.Add(this.btnShowBalloon);
            this.Controls.Add(this.btnMinimizeToTray);
            this.Controls.Add(this.chkTrayExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.cmsNotify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox chkTrayExit;
        private System.Windows.Forms.Button btnMinimizeToTray;
        private System.Windows.Forms.Button btnShowBalloon;
        private System.Windows.Forms.ContextMenuStrip cmsNotify;
        private System.Windows.Forms.ToolStripTextBox cmsiShow;
        private System.Windows.Forms.ToolStripTextBox cmsiExit;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

