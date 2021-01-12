using System;
using System.Runtime.Serialization;

namespace BybitAPI.Api.Exceptions
{
    [Serializable]
    internal class JsonConvertException : Exception
    {
        public JsonConvertException()
        {
        }

        public JsonConvertException(string message) : base(message)
        {
        }

        public JsonConvertException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected JsonConvertException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}