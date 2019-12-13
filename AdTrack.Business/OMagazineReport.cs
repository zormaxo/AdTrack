using AdTrack.Data;
using AdTrack.Data.Model;
using System.Collections.Generic;

namespace AdTrack.Business
{
    public class OMagazineReportGet : AdOperations
    {
        private readonly string magazineId;

        public OMagazineReportGet(string magazineId)
        {
            this.magazineId = magazineId;
        }

        public List<MagazineReport> List
        { get; set; }

        protected override void DoJob()
        {
            MagazineReportRepository rep = new MagazineReportRepository();
            List = rep.GetList(magazineId);
        }
    }
}