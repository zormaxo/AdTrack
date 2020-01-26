using AdTrack.Data.Model;
using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AdTrack.Data
{
    public class AddressRepository : SqLiteBaseRepository
    {
        public AddressRepository(SQLiteConnection cnn) : base(cnn)
        {
        }

        public List<Address> GetList(int companyId)
        {
            const string query = "SELECT * FROM Address WHERE CompanyId = @CompanyId";
            return BsQuery<Address>(query, new { CompanyId = companyId });
        }

        public void SaveAddress(Address Obj, int CompanyId)
        {
            string query = string.Format("INSERT INTO Address (CompanyId, Town,  AddressText) VALUES ('{0}','{1}','{2}')",
                                  CompanyId, Obj.Town, Obj.AddressText);
            BaseCnn.Execute(query);
        }
    }
}