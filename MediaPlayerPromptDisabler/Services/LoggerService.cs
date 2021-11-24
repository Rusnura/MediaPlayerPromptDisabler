using System;
using System.Windows.Forms;

namespace MediaPlayerPromptDisabler
{
    public class LoggerService
    {
        private static LoggerService _instance = null;
        private ListBox printer;

        private LoggerService() { }
        public static LoggerService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LoggerService();
            }

            return _instance;
        }

        public void Log(string message)
        {
            if (printer == null)
                return;

            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            printer.Items.Add("[" + currentTime + "] " + message);
            printer.TopIndex = printer.Items.Count - 1;
        }

        public void RegisterListBoxPrinter(ListBox printer)
        {
            this.printer = printer;
        }

        public void Clear()
        {
            this.printer.Items.Clear();
        }
    }
}
