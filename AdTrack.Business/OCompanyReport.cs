using AdTrack.Data;
using AdTrack.Data.Model;
using System.Collections.Generic;

namespace AdTrack.Business
{
    public class OCompanyReportGet : AdOperations
    {
        private readonly string selectedYear;

        public OCompanyReportGet(string selectedYear)
        {
            this.selectedYear = selectedYear;
        }

        public List<CompanyReport> List
        { get; set; }

        protected override void DoJob()
        {
            CompanyReportRepository rep = new CompanyReportRepository();
            List = rep.GetList(selectedYear);
        }
    }

    public class OCompanyDetailGet : AdOperations
    {
        private readonly int companyId;
        private readonly string selectedYear;

        public OCompanyDetailGet(int companyId, string selectedYear)
        {
            this.companyId = companyId;
            this.selectedYear = selectedYear;
        }

        public List<CompanyReport> List { get; set; }
        public List<CompanyReport> SumList { get; set; }

        protected override void DoJob()
        {
            CompanyReportRepository rep = new CompanyReportRepository();
            List = rep.GetCompanyDetailList(companyId, selectedYear);
            SumList = rep.GetSumList(companyId, selectedYear);
        }
    }
}