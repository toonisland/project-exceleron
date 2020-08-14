using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_Exceleron
{
    class Log
    {
        private const int MaxLogFileAge = 2;
        private const int KeepOldLogs = 10;
        private static readonly Queue<string> LogQueue = new Queue<string>();
        public static bool Initialized { get; private set; }

        private static LogType CurrenLogType;

        internal static void Initialize(LogType logType)
        {
            CurrenLogType = logType;
            if (Initialized)
                return;
            Trace.AutoFlush = true;
            string logDir = Path.Combine(Directory.GetCurrentDirectory(), "Logs");
            string logFile = Path.Combine(logDir, "exceleron_log.txt");
            if (!Directory.Exists(logDir))
                Directory.CreateDirectory(logDir);
            else
            {
                try
                {
                    FileInfo fileInfo = new FileInfo(logFile);
                    if (fileInfo.Exists)
                    {
                        using (FileStream fs = new FileStream(logFile, FileMode.Open, FileAccess.Read, FileShare.None))
                        {
                            //can access log file => no other instance of same installation running
                        }
                        File.Move(logFile, logFile.Replace(".txt", "_" + DateTime.Now.ToUnixTime() + ".txt"));
                        //keep logs from the last 2 days plus 25 before that
                        foreach (FileInfo file in
                            new DirectoryInfo(logDir).GetFiles("exceleron_log*")
                                .Where(x => x.LastWriteTime < DateTime.Now.AddDays(-MaxLogFileAge))
                                .OrderByDescending(x => x.LastWriteTime)
                                .Skip(KeepOldLogs))
                        {
                            try
                            {
                                File.Delete(file.FullName);
                            }
                            catch
                            {
                            }
                        }
                    }
                    else
                        File.Create(logFile).Dispose();
                }
                catch (Exception)
                {
                    return;
                }
            }
            try
            {
                Trace.Listeners.Add(new TextWriterTraceListener(new StreamWriter(logFile, false)));
            }
            catch (Exception ex)
            {

            }
            Initialized = true;
            foreach (string line in LogQueue)
                Trace.WriteLine(line);
        }

        public static void WriteLine(string msg, LogType type, [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "")
        {

            string file = sourceFilePath?.Split('/', '\\').LastOrDefault()?.Split('.').FirstOrDefault();
            string line = $"{DateTime.Now.ToLongTimeString()}|{type}|{file}.{memberName} >> {msg}";
            if (Initialized)
                Trace.WriteLine(line);
            else
                LogQueue.Enqueue(line);
        }

        public static void Debug(string msg, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "")
            => WriteLine(msg, LogType.Debug, memberName, sourceFilePath);

        public static void Info(string msg, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "")
            => WriteLine(msg, LogType.Info, memberName, sourceFilePath);

        public static void Warn(string msg, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "")
            => WriteLine(msg, LogType.Warning, memberName, sourceFilePath);

        public static void Error(string msg, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "")
            => WriteLine(msg, LogType.Error, memberName, sourceFilePath);

        public static void Error(Exception ex, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "")
            => WriteLine(ex.ToString(), LogType.Error, memberName, sourceFilePath);

        public static bool TryOpenUrl(string url, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "")
        {
            try
            {
                Log.Info("[Utility.Helper.TryOpenUrl] " + url, memberName, sourceFilePath);
                Process.Start(url);
                return true;
            }
            catch (Exception e)
            {
                Log.Error("[Utility.Helper.TryOpenUrl] " + e, memberName, sourceFilePath);
                return false;
            }
        }
    }
    [Flags]
    public enum LogType
    {
        Debug,
        Info,
        Warning,
        Error
    }

    public static class DateTimeExtensions
    {
        public static long ToUnixTime(this DateTime time)
            => Math.Max(0, (long)(time.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds);

    }
}
