using AdTrack.Data.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AdTrack.Data
{
    public class CompanyReportRepository : SqLiteBaseRepository
    {
        public CompanyReportRepository(SQLiteConnection cnn) : base(cnn)
        {
        }

        public List<CompanyReport> GetList(DateTime start, DateTime end, List<int> statusList)
        {
            string sdate = start.ToString("yyyy-MM-dd");
            string edate = end.ToString("yyyy-MM-dd");
            string statuses = string.Join(",", statusList);

            string query = string.Format("SELECT co.CompanyName, co.CompanyId, COUNT(*) AdCount, st.StatusName FROM Advertisement ad" +
             " JOIN Company co ON ad.CompanyId = co.CompanyId" +
             " JOIN MagazineDate md ON ad.MagazineDateId = md.MagazineDateId" +
             " JOIN Status st ON co.Status = st.StatusId " +
             " WHERE md.Date BETWEEN '{0}' AND '{1}'" +
             " AND st.StatusId IN ({2})" +
             " GROUP BY co.CompanyName" +
             " ORDER by AdCount desc; ", sdate, edate, statuses);

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                return cnn.Query<CompanyReport>(query).AsList();
            }
        }

        public List<CompanyReport> GetCompanyDetailList(int companyId, DateTime start, DateTime end, List<int> statusList)
        {
            string sdate = start.ToString("yyyy-MM-dd");
            string edate = end.ToString("yyyy-MM-dd");
            string statuses = string.Join(",", statusList);

            string query = string.Format("SELECT ma.MagazineName, md.Date, pa.PageDesc" +
                    " FROM Advertisement ad" +
                    " JOIN MagazineDate md ON ad.MagazineDateId = md.MagazineDateId" +
                    " JOIN Magazine ma ON ma.MagazineId = md.MagazineId" +
                    " JOIN Page pa ON pa.PageId = ad.PageId" +
                    " WHERE ad.CompanyId = {0} " +
                    " AND md.Date BETWEEN '{1}' AND '{2}'" +
                                 " AND st.StatusId IN ({3})" +
                    " ORDER BY md.Date DESC", companyId, sdate, edate, statuses);

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                return cnn.Query<CompanyReport>(query).AsList();
            }
        }

        public List<CompanyReport> GetSumList(int companyId, DateTime start, DateTime end, List<int> statusList)
        {
            string sdate = start.ToString("yyyy-MM-dd");
            string edate = end.ToString("yyyy-MM-dd");
            string statuses = string.Join(",", statusList);

            string query = string.Format("SELECT ma.MagazineName, COUNT(*) AdCount FROM MagazineDate md" +
                   " JOIN Advertisement ad ON md.MagazineDateId = ad.MagazineDateId" +
                   " JOIN Magazine ma ON ma.MagazineId = md.MagazineId" +
                   " WHERE ad.CompanyId = {0}" +
                   " AND md.Date BETWEEN '{1}' AND '{2}'" +
                                " AND st.StatusId IN ({3})" +
                   " GROUP BY ma.MagazineId" +
                   " ORDER BY COUNT(*) DESC", companyId, sdate, edate, statuses);

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                return cnn.Query<CompanyReport>(query).AsList();
            }
        }
    }
}