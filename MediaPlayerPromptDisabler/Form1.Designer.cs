
namespace MediaPlayerPromptDisabler
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_VolumeUp = new System.Windows.Forms.Button();
            this.btn_VolumeDown = new System.Windows.Forms.Button();
            this.gbox_mediaControl = new System.Windows.Forms.GroupBox();
            this.btn_mediaPlayPause = new System.Windows.Forms.Button();
            this.btn_mediaNext = new System.Windows.Forms.Button();
            this.btn_mediaPrevious = new System.Windows.Forms.Button();
            this.gbox_mediaPlayerWindow = new System.Windows.Forms.GroupBox();
            this.btn_disableWindowsPlayer = new System.Windows.Forms.Button();
            this.btn_enableWindowsPlayer = new System.Windows.Forms.Button();
            this.chBox_autorun = new System.Windows.Forms.CheckBox();
            this.lBox_logs = new System.Windows.Forms.ListBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showMainFormMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shownPlayerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.doExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_clearLogs = new System.Windows.Forms.Button();
            this.clearLogsTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.hideFormTimer = new System.Windows.Forms.Timer(this.components);
            this.tumasoffRuLink = new System.Windows.Forms.LinkLabel();
            this.versionLabel = new System.Windows.Forms.Label();
            this.gbox_mediaControl.SuspendLayout();
            this.gbox_mediaPlayerWindow.SuspendLayout();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_VolumeUp
            // 
            this.btn_VolumeUp.Location = new System.Drawing.Point(200, 21);
            this.btn_VolumeUp.Name = "btn_VolumeUp";
            this.btn_VolumeUp.Size = new System.Drawing.Size(188, 30);
            this.btn_VolumeUp.TabIndex = 1;
            this.btn_VolumeUp.Text = "Громкость +";
            this.btn_VolumeUp.UseVisualStyleBackColor = true;
            this.btn_VolumeUp.Click += new System.EventHandler(this.btn_VolumeUp_Click);
            // 
            // btn_VolumeDown
            // 
            this.btn_VolumeDown.Location = new System.Drawing.Point(6, 21);
            this.btn_VolumeDown.Name = "btn_VolumeDown";
            this.btn_VolumeDown.Size = new System.Drawing.Size(188, 30);
            this.btn_VolumeDown.TabIndex = 0;
            this.btn_VolumeDown.Text = "Громкость -";
            this.btn_VolumeDown.UseVisualStyleBackColor = true;
            this.btn_VolumeDown.Click += new System.EventHandler(this.btn_VolumeDown_Click);
            // 
            // gbox_mediaControl
            // 
            this.gbox_mediaControl.Controls.Add(this.btn_mediaPlayPause);
            this.gbox_mediaControl.Controls.Add(this.btn_VolumeDown);
            this.gbox_mediaControl.Controls.Add(this.btn_mediaNext);
            this.gbox_mediaControl.Controls.Add(this.btn_mediaPrevious);
            this.gbox_mediaControl.Controls.Add(this.btn_VolumeUp);
            this.gbox_mediaControl.Location = new System.Drawing.Point(12, 12);
            this.gbox_mediaControl.Name = "gbox_mediaControl";
            this.gbox_mediaControl.Size = new System.Drawing.Size(394, 97);
            this.gbox_mediaControl.TabIndex = 4;
            this.gbox_mediaControl.TabStop = false;
            this.gbox_mediaControl.Text = "Управление мультимедиа";
            // 
            // btn_mediaPlayPause
            // 
            this.btn_mediaPlayPause.Location = new System.Drawing.Point(102, 57);
            this.btn_mediaPlayPause.Name = "btn_mediaPlayPause";
            this.btn_mediaPlayPause.Size = new System.Drawing.Size(190, 30);
            this.btn_mediaPlayPause.TabIndex = 3;
            this.btn_mediaPlayPause.Text = "| |";
            this.btn_mediaPlayPause.UseVisualStyleBackColor = true;
            this.btn_mediaPlayPause.Click += new System.EventHandler(this.btn_mediaPlayPause_Click);
            // 
            // btn_mediaNext
            // 
            this.btn_mediaNext.Location = new System.Drawing.Point(298, 57);
            this.btn_mediaNext.Name = "btn_mediaNext";
            this.btn_mediaNext.Size = new System.Drawing.Size(90, 30);
            this.btn_mediaNext.TabIndex = 4;
            this.btn_mediaNext.Text = ">>";
            this.btn_mediaNext.UseVisualStyleBackColor = true;
            this.btn_mediaNext.Click += new System.EventHandler(this.btn_mediaNext_Click);
            // 
            // btn_mediaPrevious
            // 
            this.btn_mediaPrevious.Location = new System.Drawing.Point(6, 57);
            this.btn_mediaPrevious.Name = "btn_mediaPrevious";
            this.btn_mediaPrevious.Size = new System.Drawing.Size(90, 30);
            this.btn_mediaPrevious.TabIndex = 2;
            this.btn_mediaPrevious.Text = "<<";
            this.btn_mediaPrevious.UseVisualStyleBackColor = true;
            this.btn_mediaPrevious.Click += new System.EventHandler(this.btn_mediaPrevious_Click);
            // 
            // gbox_mediaPlayerWindow
            // 
            this.gbox_mediaPlayerWindow.Controls.Add(this.btn_disableWindowsPlayer);
            this.gbox_mediaPlayerWindow.Controls.Add(this.btn_enableWindowsPlayer);
            this.gbox_mediaPlayerWindow.Location = new System.Drawing.Point(12, 115);
            this.gbox_mediaPlayerWindow.Name = "gbox_mediaPlayerWindow";
            this.gbox_mediaPlayerWindow.Size = new System.Drawing.Size(394, 101);
            this.gbox_mediaPlayerWindow.TabIndex = 5;
            this.gbox_mediaPlayerWindow.TabStop = false;
            this.gbox_mediaPlayerWindow.Text = "Всплывающее окно мультимедиа Windows";
            // 
            // btn_disableWindowsPlayer
            // 
            this.btn_disableWindowsPlayer.Location = new System.Drawing.Point(7, 21);
            this.btn_disableWindowsPlayer.Name = "btn_disableWindowsPlayer";
            this.btn_disableWindowsPlayer.Size = new System.Drawing.Size(381, 32);
            this.btn_disableWindowsPlayer.TabIndex = 5;
            this.btn_disableWindowsPlayer.Text = "Отключить окно пллера Windows";
            this.btn_disableWindowsPlayer.UseVisualStyleBackColor = true;
            this.btn_disableWindowsPlayer.Click += new System.EventHandler(this.btn_disableWindowsPlayer_Click);
            // 
            // btn_enableWindowsPlayer
            // 
            this.btn_enableWindowsPlayer.Location = new System.Drawing.Point(7, 59);
            this.btn_enableWindowsPlayer.Name = "btn_enableWindowsPlayer";
            this.btn_enableWindowsPlayer.Size = new System.Drawing.Size(381, 32);
            this.btn_enableWindowsPlayer.TabIndex = 6;
            this.btn_enableWindowsPlayer.Text = "Включить окно пллера Windows";
            this.btn_enableWindowsPlayer.UseVisualStyleBackColor = true;
            this.btn_enableWindowsPlayer.Click += new System.EventHandler(this.btn_enableWindowsPlayer_Click);
            // 
            // chBox_autorun
            // 
            this.chBox_autorun.AutoSize = true;
            this.chBox_autorun.Location = new System.Drawing.Point(12, 222);
            this.chBox_autorun.Name = "chBox_autorun";
            this.chBox_autorun.Size = new System.Drawing.Size(265, 21);
            this.chBox_autorun.TabIndex = 7;
            this.chBox_autorun.Text = "Добавить программу в автозапуск?";
            this.chBox_autorun.UseVisualStyleBackColor = true;
            this.chBox_autorun.CheckedChanged += new System.EventHandler(this.chBox_autorun_CheckedChanged);
            // 
            // lBox_logs
            // 
            this.lBox_logs.FormattingEnabled = true;
            this.lBox_logs.HorizontalScrollbar = true;
            this.lBox_logs.ItemHeight = 16;
            this.lBox_logs.Location = new System.Drawing.Point(12, 249);
            this.lBox_logs.Name = "lBox_logs";
            this.lBox_logs.Size = new System.Drawing.Size(394, 132);
            this.lBox_logs.TabIndex = 9;
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Управление плеером Windows";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
            // 
            // trayMenu
            // 
            this.trayMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMainFormMenuItem,
            this.shownPlayerMenuItem,
            this.toolStripSeparator1,
            this.doExitMenuItem});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(302, 82);
            // 
            // showMainFormMenuItem
            // 
            this.showMainFormMenuItem.Name = "showMainFormMenuItem";
            this.showMainFormMenuItem.Size = new System.Drawing.Size(301, 24);
            this.showMainFormMenuItem.Text = "Показать окно программы";
            this.showMainFormMenuItem.Click += new System.EventHandler(this.showMainFormMenuItem_Click);
            // 
            // shownPlayerMenuItem
            // 
            this.shownPlayerMenuItem.Name = "shownPlayerMenuItem";
            this.shownPlayerMenuItem.Size = new System.Drawing.Size(301, 24);
            this.shownPlayerMenuItem.Text = "Скрывать окно плеера Windows";
            this.shownPlayerMenuItem.Click += new System.EventHandler(this.shownPlayerMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(298, 6);
            // 
            // doExitMenuItem
            // 
            this.doExitMenuItem.Name = "doExitMenuItem";
            this.doExitMenuItem.Size = new System.Drawing.Size(301, 24);
            this.doExitMenuItem.Text = "Выход";
            this.doExitMenuItem.Click += new System.EventHandler(this.doExitMenuItem_Click);
            // 
            // btn_clearLogs
            // 
            this.btn_clearLogs.Location = new System.Drawing.Point(364, 237);
            this.btn_clearLogs.Name = "btn_clearLogs";
            this.btn_clearLogs.Size = new System.Drawing.Size(22, 23);
            this.btn_clearLogs.TabIndex = 8;
            this.btn_clearLogs.Text = "C";
            this.clearLogsTooltip.SetToolTip(this.btn_clearLogs, "Очистить логи");
            this.btn_clearLogs.UseVisualStyleBackColor = true;
            this.btn_clearLogs.Click += new System.EventHandler(this.btn_clearLogs_Click);
            // 
            // clearLogsTooltip
            // 
            this.clearLogsTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // hideFormTimer
            // 
            this.hideFormTimer.Interval = 200;
            this.hideFormTimer.Tick += new System.EventHandler(this.hideFormTimer_Tick);
            // 
            // tumasoffRuLink
            // 
            this.tumasoffRuLink.AutoSize = true;
            this.tumasoffRuLink.Location = new System.Drawing.Point(9, 382);
            this.tumasoffRuLink.Name = "tumasoffRuLink";
            this.tumasoffRuLink.Size = new System.Drawing.Size(79, 17);
            this.tumasoffRuLink.TabIndex = 10;
            this.tumasoffRuLink.TabStop = true;
            this.tumasoffRuLink.Text = "tumasoff.ru";
            this.tumasoffRuLink.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tumasoffRuLink_MouseClick);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(354, 382);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(52, 17);
            this.versionLabel.TabIndex = 11;
            this.versionLabel.Text = "ver 1.0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 402);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.tumasoffRuLink);
            this.Controls.Add(this.btn_clearLogs);
            this.Controls.Add(this.lBox_logs);
            this.Controls.Add(this.chBox_autorun);
            this.Controls.Add(this.gbox_mediaPlayerWindow);
            this.Controls.Add(this.gbox_mediaControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление плеером Windows";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbox_mediaControl.ResumeLayout(false);
            this.gbox_mediaPlayerWindow.ResumeLayout(false);
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_VolumeUp;
        private System.Windows.Forms.Button btn_VolumeDown;
        private System.Windows.Forms.GroupBox gbox_mediaControl;
        private System.Windows.Forms.Button btn_mediaNext;
        private System.Windows.Forms.Button btn_mediaPrevious;
        private System.Windows.Forms.Button btn_mediaPlayPause;
        private System.Windows.Forms.GroupBox gbox_mediaPlayerWindow;
        private System.Windows.Forms.Button btn_enableWindowsPlayer;
        private System.Windows.Forms.Button btn_disableWindowsPlayer;
        private System.Windows.Forms.CheckBox chBox_autorun;
        private System.Windows.Forms.ListBox lBox_logs;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem shownPlayerMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem doExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMainFormMenuItem;
        private System.Windows.Forms.Button btn_clearLogs;
        private System.Windows.Forms.ToolTip clearLogsTooltip;
        private System.Windows.Forms.Timer hideFormTimer;
        private System.Windows.Forms.LinkLabel tumasoffRuLink;
        private System.Windows.Forms.Label versionLabel;
    }
}

