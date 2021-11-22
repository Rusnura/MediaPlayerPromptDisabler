
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
            this.gbox_mediaControl.SuspendLayout();
            this.gbox_mediaPlayerWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_VolumeUp
            // 
            this.btn_VolumeUp.Location = new System.Drawing.Point(200, 21);
            this.btn_VolumeUp.Name = "btn_VolumeUp";
            this.btn_VolumeUp.Size = new System.Drawing.Size(188, 30);
            this.btn_VolumeUp.TabIndex = 0;
            this.btn_VolumeUp.Text = "Громкость +";
            this.btn_VolumeUp.UseVisualStyleBackColor = true;
            this.btn_VolumeUp.Click += new System.EventHandler(this.btn_VolumeUp_Click);
            // 
            // btn_VolumeDown
            // 
            this.btn_VolumeDown.Location = new System.Drawing.Point(6, 21);
            this.btn_VolumeDown.Name = "btn_VolumeDown";
            this.btn_VolumeDown.Size = new System.Drawing.Size(188, 30);
            this.btn_VolumeDown.TabIndex = 1;
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
            this.btn_mediaPlayPause.TabIndex = 4;
            this.btn_mediaPlayPause.Text = "| |";
            this.btn_mediaPlayPause.UseVisualStyleBackColor = true;
            this.btn_mediaPlayPause.Click += new System.EventHandler(this.btn_mediaPlayPause_Click);
            // 
            // btn_mediaNext
            // 
            this.btn_mediaNext.Location = new System.Drawing.Point(298, 57);
            this.btn_mediaNext.Name = "btn_mediaNext";
            this.btn_mediaNext.Size = new System.Drawing.Size(90, 30);
            this.btn_mediaNext.TabIndex = 2;
            this.btn_mediaNext.Text = ">>";
            this.btn_mediaNext.UseVisualStyleBackColor = true;
            this.btn_mediaNext.Click += new System.EventHandler(this.btn_mediaNext_Click);
            // 
            // btn_mediaPrevious
            // 
            this.btn_mediaPrevious.Location = new System.Drawing.Point(6, 57);
            this.btn_mediaPrevious.Name = "btn_mediaPrevious";
            this.btn_mediaPrevious.Size = new System.Drawing.Size(90, 30);
            this.btn_mediaPrevious.TabIndex = 3;
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
            this.btn_disableWindowsPlayer.TabIndex = 1;
            this.btn_disableWindowsPlayer.Text = "Отключить окно пллера Windows";
            this.btn_disableWindowsPlayer.UseVisualStyleBackColor = true;
            this.btn_disableWindowsPlayer.Click += new System.EventHandler(this.btn_disableWindowsPlayer_Click);
            // 
            // btn_enableWindowsPlayer
            // 
            this.btn_enableWindowsPlayer.Location = new System.Drawing.Point(7, 59);
            this.btn_enableWindowsPlayer.Name = "btn_enableWindowsPlayer";
            this.btn_enableWindowsPlayer.Size = new System.Drawing.Size(381, 32);
            this.btn_enableWindowsPlayer.TabIndex = 0;
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
            this.chBox_autorun.TabIndex = 6;
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
            this.lBox_logs.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 396);
            this.Controls.Add(this.lBox_logs);
            this.Controls.Add(this.chBox_autorun);
            this.Controls.Add(this.gbox_mediaPlayerWindow);
            this.Controls.Add(this.gbox_mediaControl);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.gbox_mediaControl.ResumeLayout(false);
            this.gbox_mediaPlayerWindow.ResumeLayout(false);
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
    }
}

