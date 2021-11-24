using System;
using System.Windows.Forms;

namespace MediaPlayerPromptDisabler
{
    public partial class MainForm : Form
    {
        private LoggerService logger = LoggerService.GetInstance();
        private MediaPlayerPromptService mediaPlayerPromptService;

        public MainForm()
        {
            InitializeComponent();

            logger.RegisterListBoxPrinter(lBox_logs);
            mediaPlayerPromptService = MediaPlayerPromptService.GetInstance();
        }

        private void doHidePlayer()
        {
            mediaPlayerPromptService.HideMediaPlayer();
            btn_disableWindowsPlayer.Enabled = false;
            btn_enableWindowsPlayer.Enabled = true;
            shownPlayerMenuItem.Checked = true;
            logger.Log("Плеер скрыт!");
            Properties.Settings.Default.IsMediaPlayerHidden = true;
            Properties.Settings.Default.Save();
        }

        private void doShowPlayer()
        {
            mediaPlayerPromptService.ShowMediaPlayer();
            btn_enableWindowsPlayer.Enabled = false;
            btn_disableWindowsPlayer.Enabled = true;
            shownPlayerMenuItem.Checked = false;
            logger.Log("Режим отображения плеера включен!");
            Properties.Settings.Default.IsMediaPlayerHidden = false;
            Properties.Settings.Default.Save();
        }

        private void btn_VolumeUp_Click(object sender, EventArgs e)
        {
            MediaControlHelper.VolumeUp();
        }

        private void btn_VolumeDown_Click(object sender, EventArgs e)
        {
            MediaControlHelper.VolumeDown();
        }

        private void btn_mediaPrevious_Click(object sender, EventArgs e)
        {
            MediaControlHelper.PreviousTrack();
        }

        private void btn_mediaNext_Click(object sender, EventArgs e)
        {
            MediaControlHelper.NextTrack();
        }

        private void btn_mediaPlayPause_Click(object sender, EventArgs e)
        {
            MediaControlHelper.PlayPause();
        }

        private void btn_disableWindowsPlayer_Click(object sender, EventArgs e)
        {
            doHidePlayer();
        }

        private void btn_enableWindowsPlayer_Click(object sender, EventArgs e)
        {
            doShowPlayer();
        }

        private void chBox_autorun_CheckedChanged(object sender, EventArgs e)
        {
            bool autorunState = chBox_autorun.Checked;
            if (!AutorunHelper.SetApplicationAutorunState(autorunState))
            {
                logger.Log("Не удалось изменить параметр автозапуска!");
                logger.Log("Проверьте доступ к реестру!");
                chBox_autorun.Checked = !autorunState;
                return;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.IsMediaPlayerHidden)
            {
                doHidePlayer();
                hideFormTimer.Enabled = true;
            }
            else
            {
                doShowPlayer();
                BringFormToFront();
            }
            chBox_autorun.Checked = AutorunHelper.GetApplicationAutorunState();
        }

        private void shownPlayerMenuItem_Click(object sender, EventArgs e)
        {
            if (shownPlayerMenuItem.Checked)
            {
                doShowPlayer();
            }
            else
            {
                doHidePlayer();
            }
        }

        private void showMainFormMenuItem_Click(object sender, EventArgs e)
        {
            BringFormToFront();
        }

        private void trayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return; 

            if (this.Visible)
            {
                this.Hide();
            }
            else
            {
                BringFormToFront();
            }

        }

        private void btn_clearLogs_Click(object sender, EventArgs e)
        {
            logger.Clear();
        }

        public void BringFormToFront()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void doExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hideFormTimer_Tick(object sender, EventArgs e) // Sorry, but it's very simple method to hide form at startup
        {
            this.Hide();
            hideFormTimer.Enabled = false;
        }

        private void tumasoffRuLink_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("https://tumasoff.ru");
        }
    }
}
