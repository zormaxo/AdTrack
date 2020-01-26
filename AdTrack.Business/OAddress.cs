using AdTrack.Data;
using AdTrack.Data.Model;
using System.Collections.Generic;

namespace AdTrack.Business
{
    public class OAddressGet : AdOperations
    {
        private readonly int _companyId;

        public List<Address> AddressList

        { get; set; }

        public OAddressGet(int companyId)
        {
            _companyId = companyId;
        }

        protected override void DoJob()
        {
            AddressRepository rep = new AddressRepository(OpConn);
            AddressList = rep.GetList(_companyId);
        }
    }
}