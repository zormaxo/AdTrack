using AdTrack.Data.Model;
using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AdTrack.Data
{
    public class MagazineDateRepository : SqLiteBaseRepository
    {
        public MagazineDateRepository(SQLiteConnection cnn)
        {
            Conn = cnn;
        }

        public List<MagazineDate> GetList(MagazineDate obj)
        {
            string query = string.Format("SELECT * FROM MagazineDate " +
                "JOIN Magazine " +
                "ON MagazineDate.MagazineId = Magazine.MagazineId " +
                "WHERE MagazineDate.MagazineId = {0} " +
                "AND strftime('%Y', Date) = '{1}' " +
                "ORDER BY Date", obj.MagazineId, obj.Date.Year);

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                return cnn.Query<MagazineDate>(query).AsList();
            }
        }
    }
}