using AdTrack.Data;
using AdTrack.Data.Model;
using BigSoft.Framework.Util;
using System.Collections.Generic;
using System.Linq;

namespace AdTrack.Business
{
    public class OCompanyGet : AdOperations
    {
        public List<Company> CompanyList
        { get; set; }

        protected override void DoJob()
        {
            CompanyRepository rep = new CompanyRepository(OpConn);
            CompanyList = rep.GetList();
        }
    }

    public class OCompanySave : AdOperations
    {
        private readonly Company Obj;

        public OCompanySave(Company obj)
        {
            Obj = obj;
        }

        protected override void DoJob()
        {
            CompanyRepository rep = new CompanyRepository(OpConn);
            if (string.IsNullOrEmpty(Obj.CompanyName))
                throw new BsException("Boş girilemez", OpType.UserError);

            List<Company> companyList = rep.GetList();
            if (companyList.Any(mag => mag.CompanyName == Obj.CompanyName))
                throw new BsException("Zaten mevcut kayıt", OpType.UserError);

            string query = string.Format("INSERT INTO Company (CompanyName, Status, Explanation) VALUES ('{0}',{1},'{2}');",
                Obj.CompanyName, Obj.StatusId, Obj.Explanation);
            rep.QueryDb(query);

            long id = OpConn.LastInsertRowId;
            //Adres defterine kaydet
            query = string.Format("INSERT INTO Address (CompanyId, Address1,  Address2, Address3) VALUES ('{0}','{1}','{2}','{3}')",
                id, Obj.Address1, Obj.Address2, Obj.Address3);
            rep.QueryDb(query);

            //Telefon defterine kaydet
            query = string.Format("INSERT INTO Telephone (CompanyId, Telephone1, Telephone2, Telephone3) VALUES ('{0}','{1}','{2}','{3}')",
                id, Obj.Telephone1, Obj.Telephone2, Obj.Telephone3);
            rep.QueryDb(query);
        }
    }

    public class OCompanyUpdate : AdOperations
    {
        private readonly Company Obj;

        public OCompanyUpdate(Company obj)
        {
            Obj = obj;
        }

        protected override void DoJob()
        {
            CompanyRepository rep = new CompanyRepository(OpConn);

            string query = string.Format("UPDATE Company SET CompanyName = '{0}', " +
                " Status = '{1}', Explanation = '{2}' WHERE CompanyId = {3}",
                Obj.CompanyName, Obj.StatusId, Obj.Explanation, Obj.CompanyId);
            rep.QueryDb(query);

            //Adresleri sil
            query = string.Format("DELETE FROM Address WHERE CompanyId = {0}", Obj.CompanyId);
            rep.QueryDb(query);

            //Telefonları sil
            query = string.Format("DELETE FROM Telephone WHERE CompanyId = {0}", Obj.CompanyId);
            rep.QueryDb(query);

            //Adres defterine kaydet
            query = string.Format("INSERT INTO Address (CompanyId, Address1,  Address2, Address3) VALUES ('{0}','{1}','{2}','{3}')",
                Obj.CompanyId, Obj.Address1, Obj.Address2, Obj.Address3);
            rep.QueryDb(query);

            //Telefon defterine kaydet
            query = string.Format("INSERT INTO Telephone (CompanyId, Telephone1, Telephone2, Telephone3) VALUES ('{0}','{1}','{2}','{3}')",
                Obj.CompanyId, Obj.Telephone1, Obj.Telephone2, Obj.Telephone3);
            rep.QueryDb(query);
        }
    }

    public class OCompanyDelete : AdOperations
    {
        private readonly int id;

        public OCompanyDelete(int id)
        {
            this.id = id;
        }

        protected override void DoJob()
        {
            CompanyRepository rep = new CompanyRepository(OpConn);
            string query = string.Format("DELETE FROM Company WHERE CompanyId = {0}", id);
            rep.QueryDb(query);
        }
    }
}