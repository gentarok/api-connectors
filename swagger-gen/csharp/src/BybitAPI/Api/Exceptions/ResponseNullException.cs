using System;
using System.Runtime.Serialization;

namespace BybitAPI.Api.Exceptions
{
    [Serializable]
    internal class ResponseNullException : Exception
    {
        public ResponseNullException()
        {
        }

        public ResponseNullException(string message) : base(message)
        {
        }

        public ResponseNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ResponseNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}