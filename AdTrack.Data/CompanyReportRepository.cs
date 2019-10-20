using AdTrack.Data.Model;
using Dapper;
using System.Collections.Generic;

namespace AdTrack.Data
{
    public class CompanyReportRepository : SqLiteBaseRepository
    {
        public List<CompanyReport> GetList(string selectedYear)
        {
            string query;
            if (selectedYear == "Hepsi")
            {
                query = "SELECT co.CompanyName, co.CompanyId, COUNT(*) AdCount   FROM Advertisement ad " +
                  " JOIN Company co ON ad.CompanyId = co.CompanyId" +
                  " GROUP BY co.CompanyName" +
                  " ORDER by AdCount desc; ";
            }
            else
            {
                query = string.Format("SELECT co.CompanyName, co.CompanyId, COUNT(*) AdCount   FROM Advertisement ad" +
                    " JOIN Company co ON ad.CompanyId = co.CompanyId" +
                    " JOIN MagazineDate md ON ad.MagazineDateId = md.MagazineDateId" +
                    " WHERE strftime('%Y', md.Date) = '{0}'" +
                    " GROUP BY co.CompanyName" +
                    " ORDER by AdCount desc; ", selectedYear);
            }

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                return cnn.Query<CompanyReport>(query).AsList();
            }
        }

        public List<CompanyReport> GetCompanyDetailList(int companyId, string selectedYear)
        {
            string query;
            if (selectedYear == "Hepsi")
            {
                query = string.Format("SELECT ma.MagazineName, md.Date, pa.PageDesc" +
                    " FROM Advertisement ad" +
                    " JOIN MagazineDate md ON ad.MagazineDateId = md.MagazineDateId" +
                    " JOIN Magazine ma ON ma.MagazineId = md.MagazineId" +
                    " JOIN Page pa ON pa.PageId = ad.PageId" +
                    " WHERE ad.CompanyId = {0} ORDER BY md.Date DESC", companyId);
            }
            else
            {
                query = string.Format("SELECT ma.MagazineName, md.Date, pa.PageDesc" +
                    " FROM Advertisement ad" +
                    " JOIN MagazineDate md ON ad.MagazineDateId = md.MagazineDateId" +
                    " JOIN Magazine ma ON ma.MagazineId = md.MagazineId" +
                    " JOIN Page pa ON pa.PageId = ad.PageId" +
                    " WHERE ad.CompanyId = {0} " +
                    " AND strftime('%Y', md.Date) = '{1}'" +
                    " ORDER BY md.Date DESC", companyId, selectedYear);
            }

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                return cnn.Query<CompanyReport>(query).AsList();
            }
        }

        public List<CompanyReport> GetSumList(int companyId, string selectedYear)
        {
            string query;
            if (selectedYear == "Hepsi")
            {
                query = string.Format("SELECT ma.MagazineName, COUNT(*) AdCount FROM MagazineDate md" +
                    " JOIN Advertisement ad ON md.MagazineDateId = ad.MagazineDateId" +
                    " JOIN Magazine ma ON ma.MagazineId = md.MagazineId" +
                    " WHERE ad.CompanyId = {0}" +
                    " GROUP BY ma.MagazineId" +
                    " ORDER BY COUNT(*) DESC", companyId);
            }
            else
            {
                query = string.Format("SELECT ma.MagazineName, COUNT(*) AdCount FROM MagazineDate md" +
                   " JOIN Advertisement ad ON md.MagazineDateId = ad.MagazineDateId" +
                   " JOIN Magazine ma ON ma.MagazineId = md.MagazineId" +
                   " WHERE ad.CompanyId = {0}" +
                   " AND strftime('%Y', md.Date) = '{1}'" +
                   " GROUP BY ma.MagazineId" +
                   " ORDER BY COUNT(*) DESC", companyId, selectedYear);
            }

            using (var cnn = SimpleDbConnection())
            {
                cnn.Open();
                return cnn.Query<CompanyReport>(query).AsList();
            }
        }
    }
}