using AdTrack.Data;
using AdTrack.Data.Model;
using System;
using System.Collections.Generic;

namespace AdTrack.Business
{
    public class OCompanyReportGet : AdOperations
    {
        private readonly DateTime Start;
        private readonly DateTime End;
        private readonly List<int> StatusList;

        public OCompanyReportGet(DateTime start, DateTime end, List<int> statusList)
        {
            Start = start;
            End = end;
            StatusList = statusList;
        }

        public List<CompanyReport> List
        { get; set; }

        protected override void DoJob()
        {
            CompanyReportRepository rep = new CompanyReportRepository(OpConn);
            List = rep.GetList(Start, End, StatusList);
        }
    }

    public class OCompanyDetailGet : AdOperations
    {
        private readonly int companyId;
        private readonly DateTime Start;
        private readonly DateTime End;
        private readonly List<int> StatusList;

        public OCompanyDetailGet(int companyId, DateTime start, DateTime end, List<int> statusList)
        {
            this.companyId = companyId;
            Start = start;
            End = end;
            StatusList = statusList;
        }

        public List<CompanyReport> List { get; set; }
        public List<CompanyReport> SumList { get; set; }

        protected override void DoJob()
        {
            CompanyReportRepository rep = new CompanyReportRepository(OpConn);
            List = rep.GetCompanyDetailList(companyId, Start, End, StatusList);
            SumList = rep.GetSumList(companyId, Start, End, StatusList);
        }
    }
}