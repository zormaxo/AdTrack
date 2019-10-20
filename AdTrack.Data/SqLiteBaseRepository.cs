using Dapper;
using System;
using System.Data.SQLite;

namespace AdTrack.Data
{
    public class SqLiteBaseRepository
    {
        protected SqLiteBaseRepository()
        { }

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
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                cnn.Query<int>("PRAGMA foreign_keys = ON;");
                cnn.Query<int>(query);
            }
        }
    }
}