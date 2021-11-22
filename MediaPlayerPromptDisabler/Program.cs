using System;
using System.Threading;
using System.Windows.Forms;

namespace MediaPlayerPromptDisabler
{
    static class Program
    {
        private static bool isApplicationInstanceCreated = false;
        private static Mutex instanceMutex = new Mutex(true, "MediaPlayerPromptDisablerApplication", out isApplicationInstanceCreated);

        [STAThread]
        static void Main()
        {
            if (!isApplicationInstanceCreated)
            {
                MessageBox.Show("Приложение уже запущено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
