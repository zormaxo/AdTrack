using AdTrack.Data.Model;
using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AdTrack.Data
{
    public class StatusRepository : SqLiteBaseRepository
    {
        public StatusRepository(SQLiteConnection cnn)
        {
            Conn = cnn;
        }

        public List<Status> GetList()
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                const string query = "SELECT * FROM Status ORDER BY StatusId COLLATE NOCASE";
                return cnn.Query<Status>(query).AsList();
            }
        }
    }
}