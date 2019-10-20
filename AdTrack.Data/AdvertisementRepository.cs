using AdTrack.Data.Model;
using Dapper;
using System.Collections.Generic;

namespace AdTrack.Data
{
    public class AdvertisementRepository : SqLiteBaseRepository
    {
        public List<Advertisement> GetList(int obj)
        {
            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                string query = string.Format("SELECT * FROM  Advertisement " +
                    " JOIN Company" +
                    " ON Advertisement.CompanyId = Company.CompanyId" +
                    " JOIN Page" +
                    " ON Advertisement.PageId = Page.PageId" +
                    " WHERE MagazineDateId = {0}", obj);
                return cnn.Query<Advertisement>(query).AsList();
            }
        }
    }
}