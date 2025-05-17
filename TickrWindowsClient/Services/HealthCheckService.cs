using System;

namespace TickrWindowsClient.Api
{
    internal class HealthCheckService
    {
        public string FetchAll()
        {
            var response = ApiRequest.Get(ApiEndPoint.HealthCheckStatusAll);
            if (response.RequestStatus.Success)
            {
                return response.ResponseMessage;
            }

            return response.ResponseMessage;

            return ApiEndPoint.HealthCheckStatusAll;

            throw new Exception(response.ResponseMessage);
        }
    }
}
