using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace MediaPlayerPromptDisabler
{
    public class MediaPlayerPromptService
    {
        private LoggerService logger = LoggerService.GetInstance();
        private static MediaPlayerPromptService _instance = null;
        private IntPtr pMediaPlayerFloatingWindow = IntPtr.Zero;

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern bool IsWindow(IntPtr hWnd);

        private MediaPlayerPromptService() 
        {
            FindFloatingMediaPlayerWindow();
        }

        public static MediaPlayerPromptService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MediaPlayerPromptService();
            }

            return _instance;
        }

        public void FindFloatingMediaPlayerWindow()
        {
            int attempts = 0;
            while (pMediaPlayerFloatingWindow == IntPtr.Zero && attempts < 10)
            {
                // Emulate volume up && volume down for show floating media control window
                MediaControlHelper.VolumeUp();
                MediaControlHelper.VolumeDown();

                // Find windows
                pMediaPlayerFloatingWindow = FindPairOfNativeAndDirectUIHWNDs();

                if (pMediaPlayerFloatingWindow == IntPtr.Zero)
                {
                    attempts++;
                    Thread.Sleep(1000 * attempts);
                }
            }
        }

        public void ShowMediaPlayer()
        {
            if (!IsWindow(pMediaPlayerFloatingWindow))
            {
                logger.Log("Окно плеера невалидно. Попытка актуализации!");
                FindFloatingMediaPlayerWindow();
            }

            ShowWindow(pMediaPlayerFloatingWindow, 9); // SW_RESTORE
            // Emulate Volume Up && Volume Down 
            MediaControlHelper.VolumeDown();
            MediaControlHelper.VolumeUp();
        }
        public void HideMediaPlayer()
        {
            if (!IsWindow(pMediaPlayerFloatingWindow))
            {
                logger.Log("Окно плеера невалидно. Попытка актуализации!");
                FindFloatingMediaPlayerWindow();
            }

            ShowWindow(pMediaPlayerFloatingWindow, 6); // SW_MINIMIZE
        }

        private IntPtr FindPairOfNativeAndDirectUIHWNDs()
        {
            logger.Log("Пытаюсь найти окно плеера...");
            IntPtr pWindowsHostWindow = IntPtr.Zero;
            IntPtr pMediaPlayerFloatingWindow = IntPtr.Zero;

            // first we need search "NativeHWNDHost" windows
            while ((pWindowsHostWindow = FindWindowEx(IntPtr.Zero, pWindowsHostWindow, "NativeHWNDHost", "")) != IntPtr.Zero)
            {
                // if "NativeHWNDHost" contains a class with name "DirectUIHWND" and it might be the media control window
                if (FindWindowEx(pWindowsHostWindow, IntPtr.Zero, "DirectUIHWND", "") != IntPtr.Zero)
                {
                    if (pMediaPlayerFloatingWindow == IntPtr.Zero)
                    {
                        pMediaPlayerFloatingWindow = pWindowsHostWindow;
                    }
                    else
                    {
                        logger.Log("Не удалось: много совпадений!");
                        // Too many "NativeHWNDHost" + "DirectUIHWND" results found: It's bad...
                        return IntPtr.Zero;
                    }
                }
            }

            if (pMediaPlayerFloatingWindow == IntPtr.Zero)
            {
                logger.Log("Окно плеера не найдено :(");
            }
            else
            {
                logger.Log("Окно успешно найдено!");
            }
            return pMediaPlayerFloatingWindow;
        }
    }
}
