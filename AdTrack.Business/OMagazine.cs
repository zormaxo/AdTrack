using AdTrack.Data;
using AdTrack.Data.Model;
using BigSoft.Framework.Util;
using System.Collections.Generic;
using System.Linq;

namespace AdTrack.Business
{
    public class OMagazineGet : AdOperations
    {
        public List<Magazine> MagazineList
        { get; set; }

        protected override void DoJob()
        {
            MagazineRepository rep = new MagazineRepository(OpConn);
            MagazineList = rep.GetList();
        }
    }

    public class OMagazineSave : AdOperations
    {
        private readonly string magazineName;

        public OMagazineSave(string name)
        {
            magazineName = name;
        }

        protected override void DoJob()
        {
            MagazineRepository rep = new MagazineRepository(OpConn);
            if (string.IsNullOrEmpty(magazineName))
                throw new BsException("Boş girilemez", OpType.UserError);

            List<Magazine> magazineList = rep.GetList();
            if (magazineList.Any(mag => mag.MagazineName == magazineName))
                throw new BsException("Zaten mevcut kayıt", OpType.UserError);

            string query = string.Format("INSERT INTO Magazine (MagazineName) VALUES ('{0}')", magazineName);
            rep.BsExecute(query);
        }
    }

    public class OMagazineDelete : AdOperations
    {
        private readonly int magazineId;

        public OMagazineDelete(int id)
        {
            magazineId = id;
        }

        protected override void DoJob()
        {
            MagazineRepository rep = new MagazineRepository(OpConn);
            string query = string.Format("DELETE FROM Magazine WHERE MagazineId = {0}", magazineId);
            rep.BsExecute(query);
        }
    }

    public class OMagazineUpdate : AdOperations
    {
        private readonly Magazine magazine;

        public OMagazineUpdate(Magazine magazine)
        {
            this.magazine = magazine;
        }

        protected override void DoJob()
        {
            MagazineRepository rep = new MagazineRepository(OpConn);
            string query = string.Format("UPDATE Magazine SET MagazineName = '{0}' WHERE MagazineId = {1}", magazine.MagazineName, magazine.MagazineId);
            rep.BsExecute(query);
        }
    }
}