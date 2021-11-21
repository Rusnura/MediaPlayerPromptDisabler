using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MediaPlayerPromptDisabler
{
    public class MediaControlHelper
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        public static void VolumeUp()
        {
            keybd_event((byte)Keys.VolumeUp, 0, 0, 0);
        }

        public static void VolumeDown()
        {
            keybd_event((byte)Keys.VolumeDown, 0, 0, 0);
        }

        public static void NextTrack()
        {
            keybd_event((byte)Keys.MediaNextTrack, 0, 0, 0);
        }

        public static void PreviousTrack()
        {
            keybd_event((byte)Keys.MediaPreviousTrack, 0, 0, 0);
        }

        public static void PlayPause()
        {
            keybd_event((byte)Keys.MediaPlayPause, 0, 0, 0);
        }
    }
}
