using System;

namespace BigSoft.Framework.Util
{
    public class BsNewResult
    {
        public string Message { get; set; }
        public OpType OpType { get; set; }
        public Exception Exception { get; set; }
        public object Value { get; set; }
    }

    public enum OpType
    {
        Successful,
        UserError,
        SystemError
    }
}