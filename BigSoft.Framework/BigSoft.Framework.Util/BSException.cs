using System;
using System.Runtime.Serialization;

namespace BigSoft.Framework.Util
{
    [Serializable]
    public class BsException : Exception
    {
        public OpType OpType { get; }

        public BsException() : base()
        { }

        public BsException(string msg, OpType type)
            : base(msg)
        {
            OpType = type;
        }

        public BsException(string message) : base(message)
        {
        }

        public BsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}