namespace AdTrack.Data.Model
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string Explanation { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Telephone3 { get; set; }
    }
}