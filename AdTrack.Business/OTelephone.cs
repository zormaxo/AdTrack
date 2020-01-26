using AdTrack.Data;
using AdTrack.Data.Model;
using System.Collections.Generic;

namespace AdTrack.Business
{
    public class OTelephoneGet : AdOperations
    {
        private readonly int _companyId;

        public List<Telephone> TelephoneList
        { get; set; }

        public OTelephoneGet(int companyId)
        {
            _companyId = companyId;
        }

        protected override void DoJob()
        {
            TelephoneRepository rep = new TelephoneRepository(OpConn);
            TelephoneList = rep.GetList(_companyId);
        }
    }
}