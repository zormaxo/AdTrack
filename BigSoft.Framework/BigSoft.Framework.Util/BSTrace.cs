using System;
using System.Configuration;
using System.IO;

namespace BigSoft.Framework.Util
{
    public static class BsTrace
    {
        private const string DEFAULT_PATH = "C:\\OmerLog\\";
        private const string TRACE_FILE_NAME = "Log";
        private static string _fileName;
        private  static string _traceLine;

        private static void Prepare(string msg, string callingMethod, TraceLvl traceLvl)
        {
            string logPath = ConfigurationManager.AppSettings["LogPath"] ?? DEFAULT_PATH;

            if (!Directory.Exists(logPath))
                Directory.CreateDirectory(logPath);

            if (logPath != string.Empty && !logPath.EndsWith("\\"))
                logPath = logPath + "\\";

            _fileName = logPath + TRACE_FILE_NAME + '_' + DateTime.Now.ToString("yyyyMMdd") + ".txt";
            _traceLine = String.Format("[{0}] [{1}] [{2}] {3}", DateTime.Now.ToString("HH:mm:ss.fff"), traceLvl, callingMethod, msg);
        }

        public static void WriteLine(string msg, string callingMethod, TraceLvl traceLvl)
        {
            StreamWriteLine(msg, callingMethod, traceLvl);
        }

        public static void WriteEntityLog(string msg)
        {
            StreamWrite(msg, null, TraceLvl.INF, true);
        }

        public static void AddBlankLine()
        {
            StreamWriteLine("", null, TraceLvl.INF, true);
        }

        private static void StreamWriteLine(string msg, string callingMethod, TraceLvl traceLvl, bool force = false)
        {
            Prepare(msg, callingMethod, traceLvl);

            if (force)
                _traceLine = msg;

            using (StreamWriter sw = new StreamWriter(_fileName, true))
            {
                sw.WriteLine(_traceLine);
                sw.Close();
            }
        }

        private static void StreamWrite(string msg, string callingMethod, TraceLvl traceLvl, bool force = false)
        {
            Prepare(msg, callingMethod, traceLvl);

            if (force)
                _traceLine = msg;

            using (StreamWriter sw = new StreamWriter(_fileName, true))
            {
                sw.Write(_traceLine);
                sw.Close();
            }
        }
    }

    public enum TraceLvl
    {
        INF,
        ERR
    }
}
