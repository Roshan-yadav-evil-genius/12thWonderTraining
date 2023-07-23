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
                    fileStream.Flush();
                    // why we need flush?
                    //  In critical applications where data integrity is crucial, you may want to call Flush() after writing important data to ensure that it is immediately persisted to disk. This reduces the risk of data loss in case of a system crash or unexpected shutdown.

                    // In multi-threaded scenarios, you may use Flush() to synchronize data between threads. When one thread finishes writing data to the stream, you can call Flush() to ensure that the data is visible to other threads immediately.
                }
            }
        }


    }
}