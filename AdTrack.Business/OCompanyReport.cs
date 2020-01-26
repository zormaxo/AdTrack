using AdTrack.Data;
using AdTrack.Data.Model;
using System;
using System.Collections.Generic;

namespace AdTrack.Business
{
    public class OCompanyReportGet : AdOperations
    {
        private readonly DateTime _start;
        private readonly DateTime _end;
        private readonly List<int> _statusList;
        private readonly bool _fair;

        public List<CompanyReport> List { get; set; }

        public OCompanyReportGet(DateTime start, DateTime end, List<int> statusList, bool fair)
        {
            _fair = fair;
            _start = start;
            _end = end;
            _statusList = statusList;
        }

        protected override void DoJob()
        {
            CompanyReportRepository rep = new CompanyReportRepository(OpConn);
            List<string> fairDates = OCompanyReportUtil.GetFairDateList();
            List = rep.GetList(_start, _end, _statusList, _fair, fairDates);
        }
    }

    public class OCompanyDetailGet : AdOperations
    {
        private readonly int _companyId;
        private readonly DateTime _start;
        private readonly DateTime _end;

        public List<CompanyReport> List { get; set; }
        public List<CompanyReport> SumList { get; set; }

        public OCompanyDetailGet(int companyId, DateTime start, DateTime end)
        {
            _companyId = companyId;
            _start = start;
            _end = end;
        }

        protected override void DoJob()
        {
            CompanyReportRepository rep = new CompanyReportRepository(OpConn);
            List = rep.GetCompanyDetailList(_companyId, _start, _end);
            SumList = rep.GetSumList(_companyId, _start, _end);
        }
    }

    public class OCompanyAddressGet : AdOperations
    {
        private readonly DateTime _start;
        private readonly DateTime _end;
        private readonly List<int> _statusList;
        private readonly bool _fair;
        public List<CompanyReport> List { get; set; }

        public OCompanyAddressGet(DateTime start, DateTime end, List<int> statusList, bool fair)
        {
            _fair = fair;
            _start = start;
            _end = end;
            _statusList = statusList;
        }

        protected override void DoJob()
        {
            CompanyReportRepository rep = new CompanyReportRepository(OpConn);
            List<string> fairDates = OCompanyReportUtil.GetFairDateList();
            List = rep.GetAddress(_start, _end, _statusList, _fair, fairDates);
        }
    }

    public static class OCompanyReportUtil
    {
        public static List<string> GetFairDateList()
        {
            List<string> fairDates = new List<string>();
            fairDates.Add("2016-03-01");
            fairDates.Add("2016-10-01");
            fairDates.Add("2017-03-01");
            fairDates.Add("2017-10-01");
            fairDates.Add("2018-03-01");
            fairDates.Add("2018-10-01");
            fairDates.Add("2019-03-01");
            fairDates.Add("2019-10-01");
            fairDates.Add("2020-03-01");
            fairDates.Add("2020-10-01");
            fairDates.Add("2021-03-01");
            fairDates.Add("2021-10-01");
            fairDates.Add("2022-03-01");
            fairDates.Add("2022-10-01");
            return fairDates;
        }
    }
}