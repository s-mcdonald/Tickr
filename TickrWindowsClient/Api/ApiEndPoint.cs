using System;
using System.Collections.Generic;

namespace TickrWindowsClient.Api
{
    // perhaps reconsider this approach
    public static class ApiEndPoint
    {
        private const string Protocol = "http";

        private const string BaseUrl = "://localhost:5112/";
        private const string TickerBaseUrl = "://localhost:5054/";

        public static string HealthCheckStatusAll => $"{Protocol}{BaseUrl}tickr/status/all";

        public static string ListAllAssets => $"{Protocol}{TickerBaseUrl}tickr/assets/list";
    }
}
