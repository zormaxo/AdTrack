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
            CompanyRepository rep = new CompanyRepository();
            CompanyList = rep.GetList();
        }
    }

    public class OCompanySave : AdOperations
    {
        private readonly string companyName;

        public OCompanySave(string name)
        {
            companyName = name;
        }

        protected override void DoJob()
        {
            CompanyRepository rep = new CompanyRepository();
            if (string.IsNullOrEmpty(companyName))
                throw new BsException("Boş girilemez", OpType.UserError);

            List<Company> magazineList = rep.GetList();
            if (magazineList.Any(mag => mag.CompanyName == companyName))
                throw new BsException("Zaten mevcut kayıt", OpType.UserError);

            string query = string.Format("INSERT INTO Company (CompanyName) VALUES ('{0}')", companyName);
            rep.QueryDb(query);
        }
    }

    public class OCompanyUpdate : AdOperations
    {
        private readonly Company company;

        public OCompanyUpdate(Company company)
        {
            this.company = company;
        }

        protected override void DoJob()
        {
            CompanyRepository rep = new CompanyRepository();
            string query = string.Format("UPDATE Company SET CompanyName = '{0}' WHERE CompanyId = {1}", company.CompanyName, company.CompanyId);
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
            CompanyRepository rep = new CompanyRepository();
            string query = string.Format("DELETE FROM Company WHERE CompanyId = {0}", id);
            rep.QueryDb(query);
        }
    }
}