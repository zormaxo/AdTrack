using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AdTrack.Data
{
    public class SqLiteBaseRepository
    {
        protected readonly SQLiteConnection BaseCnn;

        public SqLiteBaseRepository(SQLiteConnection cnn)
        {
            BaseCnn = cnn;
        }

        public static SQLiteConnection SimpleDbConnection()
        {
            string dbFile = Environment.CurrentDirectory + "\\AdTrackDb.sqlite";
            return new SQLiteConnection("Data Source=" + dbFile);
        }

        public List<T> BsQuery<T>(string query, object param = null)
        {
            BaseCnn.Execute("PRAGMA foreign_keys = ON;");
            return BaseCnn.Query<T>(query, param).AsList();
        }

        public void BsExecute(string query, object param = null)
        {
            BaseCnn.Execute("PRAGMA foreign_keys = ON;");
            BaseCnn.Execute(query, param);
        }
    }
}