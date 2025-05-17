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

        // This calls the TickerHealthService and gets all servers in single request
        public static string HealthCheckStatusAll => $"{Protocol}{BaseUrl}tickr/status";

        // List all assets
        // This is will eventually become a large list so it prob needs additional filtering
        // such as by exchange, of by type ect
        public static string ListAllAssets => $"{Protocol}{TickerBaseUrl}tickr/assets";


        // Get Current Quote
        // if there are two ticker symbols that have the same code, we need to differentiate them
        // by excahnge, so the exchange suffix is optional, however if a result has
        // 2 or more items only the first result will be displayed
        public static string GetQuote => $"{Protocol}{TickerBaseUrl}tickr/assets/quote/[symbol][exchange_suffix?]";


        // Get Historical Price Data
        public static string ListHistoricalAllAssets => $"{Protocol}{TickerBaseUrl}tickr/assets/history/[symbol]/interval/[interval]";

        // Get a list of available exchanges
        public static string ListExchanges => $"{Protocol}{TickerBaseUrl}tickr/assets/exchanges";

        // we can add more later
    }
}
