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
            mediaPlayerPromptService.HideMediaPlayer();
            btn_disableWindowsPlayer.Enabled = false;
            btn_enableWindowsPlayer.Enabled = true;
        }

        private void btn_enableWindowsPlayer_Click(object sender, EventArgs e)
        {
            mediaPlayerPromptService.ShowMediaPlayer();
            btn_enableWindowsPlayer.Enabled = false;
            btn_disableWindowsPlayer.Enabled = true;
        }

        private void chBox_autorun_CheckedChanged(object sender, EventArgs e)
        {
            bool autorunState = chBox_autorun.Checked;
            if (!AutorunHelper.SetApplicationAutorunState(autorunState))
            {
                chBox_autorun.Checked = !autorunState;
            }
        }
    }
}
