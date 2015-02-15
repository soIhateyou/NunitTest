using System;
using System.IO;

namespace LogAn
{
    public class LogAnalyzer
    {
        public bool IsValidLogFileName(string fileName)
        {
            //if (!File.Exists(fileName))
            //{
            //    throw new Exception("No log file with that name exists");
            //}
            if (!fileName.ToLower().EndsWith(".slf"))
            {
                wasLastFileNameValid = false;
                return false;
            }

            wasLastFileNameValid = true;
            return true;
        }

        public bool wasLastFileNameValid { get; set; }
    }
}
