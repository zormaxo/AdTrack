using AdTrack.Data.Model;
using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AdTrack.Data
{
    public class CompanyRepository : SqLiteBaseRepository
    {
        public CompanyRepository(SQLiteConnection cnn)
        {
            Conn = cnn;
        }

        public List<Company> GetList()
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                const string query = "SELECT * FROM Company co JOIN Status st ON co.Status = st.StatusId" +
                    " LEFT JOIN Address ad ON co.CompanyId = ad.CompanyId" +
                    " LEFT JOIN Telephone te ON co.CompanyId = te.CompanyId" +
                    " ORDER BY CompanyName COLLATE NOCASE";

                return cnn.Query<Company>(query).AsList();
            }
        }
    }
}