using AdTrack.Data.Model;
using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AdTrack.Data
{
    public class MagazineReportRepository : SqLiteBaseRepository
    {
        public MagazineReportRepository(SQLiteConnection cnn) : base(cnn)
        {
        }

        public List<MagazineReport> GetList(string magazineId)
        {
            string query = string.Format("SELECT co.CompanyName, COUNT(*) AdCount FROM Advertisement ad" +
                    " JOIN MagazineDate md ON ad.MagazineDateId = md.MagazineDateId" +
                    " JOIN Magazine ma ON md.MagazineId = ma.MagazineId" +
                    " JOIN Company co ON ad.CompanyId = co.CompanyId" +
                    " WHERE ma.MagazineId = {0}" +
                    " GROUP BY co.CompanyId" +
                    " ORDER by AdCount desc;", magazineId);

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                return cnn.Query<MagazineReport>(query).AsList();
            }
        }
    }
}