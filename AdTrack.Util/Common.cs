using FastMember;
using System.Collections.Generic;
using System.Data;

namespace AdTrack.Util
{
    public static class Common
    {
        public static List<int> GetYears()
        {
            return new List<int> { 2020, 2019, 2018, 2017, 2016 };
        }

        public static DataTable ConvertToDatatable<T>(IEnumerable<T> source, params string[] members)
        {
            DataTable table = new DataTable();
            using (var reader = ObjectReader.Create(source, members))
            {
                table.Load(reader);
            }
            return table;
        }

        public static void WriteDtToExcel<T>(IEnumerable<T> source, string name, params string[] members)
        {
            DataTable table = new DataTable();
            using (var reader = ObjectReader.Create(source, members))
            {
                table.Load(reader);
            }

            DataSet ds = new DataSet("New_DataSet");
            ds.Tables.Add(table);

            //Here's the easy part. Create the Excel worksheet from the data set
            ExcelLibrary.DataSetHelper.CreateWorkbook(name + ".xls", ds);
        }

        public static void WriteDsToExcel(string name, params DataTable[] tables)
        {
            DataSet ds = new DataSet("New_DataSet");
            foreach (var table in tables)
            {
                ds.Tables.Add(table);
            }

            //Here's the easy part. Create the Excel worksheet from the data set
            ExcelLibrary.DataSetHelper.CreateWorkbook(name + ".xls", ds);
        }
    }

    public enum PageType
    {
        Kapak = 1,
        KapakIci,
        ArkaKapak,
        IkiSayfa,
        TekSayfa
    }
}