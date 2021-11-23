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
            printer.Items.Insert(0, "[" + currentTime + "] " + message);
        }

        public void RegisterListBoxPrinter(ListBox printer)
        {
            this.printer = printer;
        }
    }
}
