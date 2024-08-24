using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns_Singleton
{
    public sealed class SingletonLogger
    {
        private static SingletonLogger _instance = null;
        private static readonly object _lock = new object();
        private readonly string _logFilePath;

        // Private constructor to prevent instantiation
        private SingletonLogger()
        {
            _logFilePath = "app.log"; // Specify the log file path
        }

        // Public static method to get the single instance of the Logger class
        public static SingletonLogger Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingletonLogger();
                        }
                    }
                }
                return _instance;
            }
        }

        // Method to log messages to the file
        public void Log(string message)
        {
            lock (_lock) // Ensure thread-safe write access
            {
                using (StreamWriter writer = new StreamWriter(_logFilePath, true))
                {
                    writer.WriteLine($"{DateTime.Now}: {message}");
                }
            }
        }
    }
}
