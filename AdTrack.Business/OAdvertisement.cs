using AdTrack.Data;
using AdTrack.Data.Model;
using System.Collections.Generic;

namespace AdTrack.Business
{
    public class OAdvertisementGet : AdOperations
    {
        private readonly int obj;

        public List<Advertisement> ObjList
        { get; set; }

        public OAdvertisementGet(int obj)
        {
            this.obj = obj;
        }

        protected override void DoJob()
        {
            AdvertisementRepository rep = new AdvertisementRepository();
            ObjList = rep.GetList(obj);
        }
    }

    public class OAdvertisementSave : AdOperations
    {
        private readonly List<Advertisement> list;
        private readonly int dateId;

        public OAdvertisementSave(List<Advertisement> advertisementList, int selectedDateId)
        {
            list = advertisementList;
            dateId = selectedDateId;
        }

        protected override void DoJob()
        {
            MagazineDateRepository rep = new MagazineDateRepository();
            string delete = string.Format("DELETE FROM Advertisement WHERE MagazineDateId = {0}", dateId);
            rep.QueryDb(delete);

            foreach (Advertisement item in list)
            {
                string query = string.Format("INSERT INTO Advertisement (MagazineDateId, CompanyId, PageId) VALUES ({0}, {1}, {2})",
                    dateId, item.CompanyId, item.PageId);
                rep.QueryDb(query);
            }
        }
    }
}