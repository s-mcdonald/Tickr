using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TickrWindowsClient.Api
{
    internal class RequestStatus
    {
        public bool Success { get; }

        public RequestStatus(bool success)
        {
            Success = success;
        }
    }
}
