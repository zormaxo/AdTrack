using AdTrack.Data.Model;
using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AdTrack.Data
{
    public class MagazineRepository : SqLiteBaseRepository
    {
        public MagazineRepository(SQLiteConnection cnn) : base(cnn)
        {
        }

        public List<Magazine> GetList()
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                const string query = "SELECT * FROM Magazine ORDER BY MagazineName COLLATE NOCASE";
                return cnn.Query<Magazine>(query).AsList();
            }
        }
    }
}