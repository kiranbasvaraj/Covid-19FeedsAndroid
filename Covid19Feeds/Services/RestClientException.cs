using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Feeds.Services
{
   public class RestClientException: Exception
    {
        public HttpStatusCode statusCode;
        public string responseBody;
        public RestClientException(string message)
            : base(message)
        {
        }

        public RestClientException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public RestClientException(Exception innerException)
            : base(innerException.Message, innerException)
        {
        }

        public RestClientException(HttpStatusCode statusCode, string responseBody)
            : base(string.Format("Request responded with status code={0}, response={1}", statusCode, responseBody))
        {
            this.statusCode = statusCode;
            this.responseBody = responseBody;
        }
    }
}
