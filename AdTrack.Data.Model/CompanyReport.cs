using System;

namespace AdTrack.Data.Model
{
    public class CompanyReport
    {
        public int AdCount { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string MagazineName { get; set; }
        public string PageDesc { get; set; }
        public DateTime Date { get; set; }
        public string StatusName { get; set; }
    }
}