using AdTrack.Data;
using AdTrack.Data.Model;
using System.Collections.Generic;

namespace AdTrack.Business
{
    public class OStatusGet : AdOperations
    {
        public List<Status> StatusList
        { get; set; }

        protected override void DoJob()
        {
            StatusRepository rep = new StatusRepository(OpConn);
            StatusList = rep.GetList();
        }
    }
}