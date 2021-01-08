using System;
using System.Runtime.Serialization;

namespace BybitAPI.Api.Exceptions
{
    [Serializable]
    internal class ResponseContentNullException : Exception
    {
        public ResponseContentNullException()
        {
        }

        public ResponseContentNullException(string message) : base(message)
        {
        }

        public ResponseContentNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ResponseContentNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}