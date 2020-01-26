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

        public List<CompanyReport> GetList(DateTime start, DateTime end, List<int> statusList, bool fair, List<string> fairDates)
        {
            string sdate = start.ToString("yyyy-MM-dd");
            string edate = end.ToString("yyyy-MM-dd");
            string statuses = string.Join(",", statusList);
            string query;
            if (fair)
            {
                query = string.Format("SELECT co.CompanyName, co.CompanyId, COUNT(*) AdCount, st.StatusName FROM Advertisement ad" +
                " JOIN Company co ON ad.CompanyId = co.CompanyId" +
                " JOIN MagazineDate md ON ad.MagazineDateId = md.MagazineDateId" +
                " JOIN Status st ON co.Status = st.StatusId " +
                " WHERE md.Date IN @fairDates" +
                " AND st.StatusId IN ({0})" +
                " GROUP BY co.CompanyName" +
                " ORDER by AdCount desc; ", statuses);

                var parameters = new DynamicParameters();
                parameters.Add("fairDates", fairDates);
                return BaseCnn.Query<CompanyReport>(query, parameters).AsList();
            }
            else
            {
                query = string.Format("SELECT co.CompanyName, co.CompanyId, COUNT(*) AdCount, st.StatusName FROM Advertisement ad" +
                " JOIN Company co ON ad.CompanyId = co.CompanyId" +
                " JOIN MagazineDate md ON ad.MagazineDateId = md.MagazineDateId" +
                " JOIN Status st ON co.Status = st.StatusId " +
                " WHERE md.Date BETWEEN '{0}' AND '{1}'" +
                " AND st.StatusId IN ({2})" +
                " GROUP BY co.CompanyName" +
                " ORDER by AdCount desc; ", sdate, edate, statuses);
                return BaseCnn.Query<CompanyReport>(query).AsList();
            }
        }

        public List<CompanyReport> GetCompanyDetailList(int companyId, DateTime start, DateTime end, bool fair, List<string> fairDates)
        {
            string sdate = start.ToString("yyyy-MM-dd");
            string edate = end.ToString("yyyy-MM-dd");
            string query;
            if (fair)
            {
                query = string.Format("SELECT ma.MagazineName, md.Date, pa.PageDesc" +
                   " FROM Advertisement ad" +
                   " JOIN MagazineDate md ON ad.MagazineDateId = md.MagazineDateId" +
                   " JOIN Magazine ma ON ma.MagazineId = md.MagazineId" +
                   " JOIN Page pa ON pa.PageId = ad.PageId" +
                   " WHERE ad.CompanyId = {0} " +
                   " AND md.Date IN @fairDates" +
                   " ORDER BY md.Date DESC", companyId);

                var parameters = new DynamicParameters();
                parameters.Add("fairDates", fairDates);
                return BaseCnn.Query<CompanyReport>(query, parameters).AsList();
            }
            else
            {
                query = string.Format("SELECT ma.MagazineName, md.Date, pa.PageDesc" +
                   " FROM Advertisement ad" +
                   " JOIN MagazineDate md ON ad.MagazineDateId = md.MagazineDateId" +
                   " JOIN Magazine ma ON ma.MagazineId = md.MagazineId" +
                   " JOIN Page pa ON pa.PageId = ad.PageId" +
                   " WHERE ad.CompanyId = {0} " +
                   " AND md.Date BETWEEN '{1}' AND '{2}'" +
                   " ORDER BY md.Date DESC", companyId, sdate, edate);
                return BaseCnn.Query<CompanyReport>(query).AsList();
            }
        }

        public List<CompanyReport> GetSumList(int companyId, DateTime start, DateTime end, bool fair, List<string> fairDates)
        {
            string sdate = start.ToString("yyyy-MM-dd");
            string edate = end.ToString("yyyy-MM-dd");
            string query;
            if (fair)
            {
                query = string.Format("SELECT ma.MagazineName, COUNT(*) AdCount FROM MagazineDate md" +
                  " JOIN Advertisement ad ON md.MagazineDateId = ad.MagazineDateId" +
                  " JOIN Magazine ma ON ma.MagazineId = md.MagazineId" +
                  " WHERE ad.CompanyId = {0}" +
                  " AND md.Date IN @fairDates" +
                  " GROUP BY ma.MagazineId" +
                  " ORDER BY COUNT(*) DESC", companyId, sdate, edate);

                var parameters = new DynamicParameters();
                parameters.Add("fairDates", fairDates);
                return BaseCnn.Query<CompanyReport>(query, parameters).AsList();
            }
            else
            {
                query = string.Format("SELECT ma.MagazineName, COUNT(*) AdCount FROM MagazineDate md" +
                    " JOIN Advertisement ad ON md.MagazineDateId = ad.MagazineDateId" +
                    " JOIN Magazine ma ON ma.MagazineId = md.MagazineId" +
                    " WHERE ad.CompanyId = {0}" +
                    " AND md.Date BETWEEN '{1}' AND '{2}'" +
                    " GROUP BY ma.MagazineId" +
                    " ORDER BY COUNT(*) DESC", companyId, sdate, edate);
                return BaseCnn.Query<CompanyReport>(query).AsList();
            }
        }

        public List<CompanyReport> GetAddress(DateTime start, DateTime end, List<int> statusList, bool fair, List<string> fairDates)
        {
            string sdate = start.ToString("yyyy-MM-dd");
            string edate = end.ToString("yyyy-MM-dd");
            string statuses = string.Join(",", statusList);
            string query;

            if (fair)
            {
                query = string.Format("SELECT co.CompanyName, st.StatusName, " +
                   " IFNULL(adr.AddressText,'') AddressText, IFNULL(tw.TownName,'') TownName, COUNT(*) AdCount" +
                   " FROM Advertisement ad JOIN Company co ON ad.CompanyId = co.CompanyId" +
                   " JOIN MagazineDate md ON ad.MagazineDateId = md.MagazineDateId" +
                   " LEFT JOIN Address adr ON adr.CompanyId = co.CompanyId" +
                   " JOIN Status st ON co.Status = st.StatusId " +
                   " LEFT JOIN Town tw ON tw.TownId = adr.Town" +
                   " WHERE md.Date IN @fairDates" +
                   " AND st.StatusId IN ({0})" +
                   " GROUP BY AddressText, co.CompanyName ORDER by AdCount desc;", statuses);

                var parameters = new DynamicParameters();
                parameters.Add("fairDates", fairDates);
                return BaseCnn.Query<CompanyReport>(query, parameters).AsList();
            }
            else
            {
                query = string.Format("SELECT co.CompanyName, st.StatusName, " +
                   " IFNULL(adr.AddressText,'') AddressText, IFNULL(tw.TownName,'') TownName, COUNT(*) AdCount" +
                   " FROM Advertisement ad JOIN Company co ON ad.CompanyId = co.CompanyId" +
                   " JOIN MagazineDate md ON ad.MagazineDateId = md.MagazineDateId" +
                   " LEFT JOIN Address adr ON adr.CompanyId = co.CompanyId" +
                   " JOIN Status st ON co.Status = st.StatusId " +
                   " LEFT JOIN Town tw ON tw.TownId = adr.Town" +
                   " WHERE md.Date BETWEEN '{0}' AND '{1}'" +
                   " AND st.StatusId IN ({2})" +
                   " GROUP BY AddressText, co.CompanyName ORDER by AdCount desc;", sdate, edate, statuses);
            }

            return BaseCnn.Query<CompanyReport>(query).AsList();
        }
    }
}