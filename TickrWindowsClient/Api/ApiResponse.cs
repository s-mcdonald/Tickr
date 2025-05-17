using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TickrWindowsClient.Api
{
    internal class ApiResponse
    {
        public RequestStatus RequestStatus { get; }

        public string ResponseMessage { get; }

        public ApiResponse(RequestStatus status, string message) 
        {
            RequestStatus = status;
            ResponseMessage = message;
        }
    }
}
