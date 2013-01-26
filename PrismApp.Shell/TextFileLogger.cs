using System;
using System.IO;
using System.Text;
using Microsoft.Practices.Prism.Logging;

namespace PrismApp.Shell
{
    public class TextFileLogger : ILoggerFacade
    {
        private readonly string _fileName = Path.Combine(Environment.CurrentDirectory, "PrismApp.log");
        private readonly object _syncLock = new object();

        public TextFileLogger()
        {
        }

        public void Log(string message, Category category, Priority priority)
        {
            WriteToFile(category.ToString(), message);
        }


        private void WriteToFile(string type, string message)
        {
            lock (_syncLock)
            {
                using (var writer = new StreamWriter(_fileName, true, Encoding.UTF8))
                {
                    writer.WriteLine(string.Format("{0:G}\t{1}:{2}", DateTime.Now, type, message));
                }
            }
        }
    }
}
