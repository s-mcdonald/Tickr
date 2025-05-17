using System;
using System.Collections.Generic;

namespace TickrWindowsClient.Api
{
    // perhaps reconsider this approach
    public static class ApiEndPoint
    {
        private const string Protocol = "http";

        private const string HealthServiceBaseUrl = "://localhost:5112/";
        private const string TickerServiceBaseUrl = "://localhost:5054/";
        // private const string TradingServiceApiBaseUrl = "://localhost:5055/";

        // This calls the TickerHealthService and gets all servers in single request
        public static string HealthCheckStatusAll => $"{Protocol}{HealthServiceBaseUrl}tickr/status";

        // List all assets
        // This is will eventually become a large list so it prob needs additional filtering
        // such as by exchange, of by type ect
        public static string ListAllAssets => $"{Protocol}{TickerServiceBaseUrl}tickr/assets";


        // Get Current Quote
        // if there are two ticker symbols that have the same code, we need to differentiate them
        // by excahnge, so the exchange suffix is optional, however if a result has
        // 2 or more items only the first result will be displayed
        public static string GetQuote => $"{Protocol}{TickerServiceBaseUrl}tickr/assets/quote/[symbol][exchange_suffix?]";


        // Get Historical Price Data
        public static string ListHistoricalData => $"{Protocol}{TickerServiceBaseUrl}tickr/assets/history/[symbol]";
        // public static string ListHistoricalData => $"{Protocol}{TickerServiceBaseUrl}tickr/assets/history/[symbol]/interval/[interval]";

        // Get a list of available exchanges
        public static string ListExchanges => $"{Protocol}{TickerServiceBaseUrl}tickr/assets/exchanges";

        // we can add more later
    }
}
