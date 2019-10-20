namespace AdTrack.Data.Model
{
    public class Advertisement
    {
        public int AdId { get; set; }
        public int MagazineDateId { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int PageId { get; set; }
        public string PageDesc { get; set; }
    }
}