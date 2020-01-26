using AdTrack.Data.Model;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AdTrack.Data
{
    public class CompanyRepository : SqLiteBaseRepository
    {
        public CompanyRepository(SQLiteConnection cnn) : base(cnn)
        {
        }

        public List<Company> GetList()
        {
            const string query = "SELECT * FROM Company co JOIN Status st ON co.Status = st.StatusId" +
                                 " ORDER BY CompanyName COLLATE NOCASE";
            return BsQuery<Company>(query);
        }
    }
}