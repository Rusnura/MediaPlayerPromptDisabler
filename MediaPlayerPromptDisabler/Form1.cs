using System;
using System.Windows.Forms;

namespace MediaPlayerPromptDisabler
{
    public partial class MainForm : Form
    {
        private MediaPlayerPromptService mediaPlayerPromptService = MediaPlayerPromptService.GetInstance();

        public MainForm()
        {
            InitializeComponent();
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
        }

        private void btn_enableWindowsPlayer_Click(object sender, EventArgs e)
        {
            mediaPlayerPromptService.ShowMediaPlayer();
        }
    }
}
