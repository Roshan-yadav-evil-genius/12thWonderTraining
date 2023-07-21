using System.IO;
using System;
using System.Text;

namespace ReadWriteOperation
{
    enum logLevel
    {
        DEBUG,
        INFO,
        WARNING,
        ERROR,
    }
    class Log
    {
        public static void logEvent(string source, logLevel level, string msg)
        {
            bool debug = false;
            DateTime dateTime = DateTime.Now;
            string filename = dateTime.Date.ToString("yyyy-MM-dd");


            string folderName = "Logs";
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), folderName);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string data = $"{level} [" + dateTime + "] " + source + $" : '{msg}'\n";

            if (debug)
            {

                Console.WriteLine(data);
            }
            else
            {
                // Append the current date to the file
                string filepath = Path.Join(folderPath, $"{filename}.log");
                using (FileStream fileStream = new FileStream(filepath, FileMode.Append, FileAccess.Write))
                {
                    DateTime currentDate = DateTime.Now;
                    byte[] logBytes = Encoding.UTF8.GetBytes(data);
                    fileStream.Write(logBytes, 0, logBytes.Length);
                }
            }
        }


    }
}