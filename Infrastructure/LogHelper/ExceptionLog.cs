using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.LogHelper
{
    public class ExceptionLog : ILog
    {
        public static void WriteLog(Exception exception,string logPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(logPath);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
                File.Create(logPath + @"Log.txt").Close();
            }
            StreamWriter streamWriter = File.AppendText(logPath + @"Log.txt");
            streamWriter.WriteLine($"*********************{DateTime.Now}*********************");
            streamWriter.WriteLine(exception.Message);
            streamWriter.WriteLine(exception.StackTrace);
            streamWriter.Flush();
            streamWriter.Close();
        }
        public static async Task WriteLogAsync(Exception exception,string logPath)
        {
            await Task.Run(() => WriteLog(exception, logPath));
        }

    }
}
