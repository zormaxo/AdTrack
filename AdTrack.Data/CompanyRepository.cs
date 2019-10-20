using AdTrack.Data.Model;
using Dapper;
using System.Collections.Generic;

namespace AdTrack.Data
{
    public class CompanyRepository : SqLiteBaseRepository
    {
        public List<Company> GetList()
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                const string query = "SELECT * FROM Company ORDER BY CompanyName COLLATE NOCASE";
                return cnn.Query<Company>(query).AsList();
            }
        }
    }
}