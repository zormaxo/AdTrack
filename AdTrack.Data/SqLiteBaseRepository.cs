using Dapper;
using System;
using System.Data.SQLite;

namespace AdTrack.Data
{
    public class SqLiteBaseRepository
    {
        public SQLiteConnection Conn { get; set; } = SimpleDbConnection();

        public static string DbFile
        {
            get { return Environment.CurrentDirectory + "\\AdTrackDb.sqlite"; }
        }

        public static SQLiteConnection SimpleDbConnection()
        {
            return new SQLiteConnection("Data Source=" + DbFile);
        }

        public void QueryDb(string query)
        {
            Conn.Query<int>("PRAGMA foreign_keys = ON;");
            Conn.Query<int>(query);
        }
    }
}