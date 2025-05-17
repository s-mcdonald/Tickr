using System;

namespace TickrWindowsClient.Api
{
    public static class ApiEndPoint
    {
        private const string Protocol = "http";

        private const string BaseUrl = "://localhost:5112/";

        public static string HealthCheckStatusAll => $"{Protocol}{BaseUrl}tickr/status/all";
    }
}
