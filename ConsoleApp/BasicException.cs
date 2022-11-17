using System;
using System.Runtime.Serialization;

namespace ConsoleApp
{
    [Serializable]
    internal class BasicException : Exception
    {
        public BasicException()
        {
        }

        public BasicException(string message) : base(message)
        {
        }

        public BasicException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BasicException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}