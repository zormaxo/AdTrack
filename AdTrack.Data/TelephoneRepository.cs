using AdTrack.Data.Model;
using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AdTrack.Data
{
    public class TelephoneRepository : SqLiteBaseRepository
    {
        public TelephoneRepository(SQLiteConnection cnn) : base(cnn)
        {
        }

        public List<Telephone> GetList(int companyId)
        {
            const string query = "SELECT * FROM Telephone WHERE CompanyId = @CompanyId";
            return BsQuery<Telephone>(query, new { CompanyId = companyId });
        }

        public void SaveTelephone(string telephone, int companyId)
        {
            string query = string.Format("INSERT INTO Telephone (CompanyId, TelNumber) VALUES ('{0}','{1}')",
                                  companyId, telephone);
            BaseCnn.Execute(query);
        }
    }
}