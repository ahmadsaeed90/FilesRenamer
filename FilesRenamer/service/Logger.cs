using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesRenamer.service
{
    public class Logger : ILogger
    {
        public delegate void LogMessage(string message);
        public delegate void LogError(string error);

        public event LogMessage OnLogMessage;
        public event LogError OnLogError;

        public void Log(string message)
        {
            OnLogMessage.Invoke(message);
        }

        public void Error(string message)
        {
            OnLogError.Invoke(message);
        }
    }
}
