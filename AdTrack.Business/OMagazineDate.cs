using AdTrack.Data;
using AdTrack.Data.Model;
using System.Collections.Generic;

namespace AdTrack.Business
{
    public class OMagazineDateGet : AdOperations
    {
        private readonly MagazineDate obj;

        public List<MagazineDate> ObjList
        { get; set; }

        public OMagazineDateGet(MagazineDate obj)
        {
            this.obj = obj;
        }

        protected override void DoJob()
        {
            MagazineDateRepository rep = new MagazineDateRepository();
            ObjList = rep.GetList(obj);
        }
    }

    public class OMagazineDateSave : AdOperations
    {
        private readonly MagazineDate obj;

        public OMagazineDateSave(MagazineDate obj)
        {
            this.obj = obj;
        }

        protected override void DoJob()
        {
            MagazineDateRepository rep = new MagazineDateRepository();
            string query = string.Format("INSERT INTO MagazineDate (MagazineId, Date) VALUES ({0}, '{1}')",
                obj.MagazineId, obj.Date.ToString("yyyy-MM-dd"));
            rep.QueryDb(query);
        }
    }

    public class OMagazineDateDelete : AdOperations
    {
        private readonly MagazineDate obj;

        public OMagazineDateDelete(MagazineDate obj)
        {
            this.obj = obj;
        }

        protected override void DoJob()
        {
            MagazineRepository rep = new MagazineRepository();
            string query = string.Format("DELETE FROM MagazineDate WHERE MagazineId = {0} AND Date = '{1}'",
                obj.MagazineId, obj.Date.ToString("yyyy-MM-dd"));
            rep.QueryDb(query);
        }
    }
}