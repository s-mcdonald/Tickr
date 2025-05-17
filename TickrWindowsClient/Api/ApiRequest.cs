using System;
using System.IO;
using System.Net;

namespace TickrWindowsClient.Api
{
    internal class ApiRequest
    {
        public static ApiResponse Get(string endpoint)
        {
            try
            {
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endpoint);
                request.Method = "GET";
                request.ContentType = "application/json";

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string jsonResponse = reader.ReadToEnd();

                    return new ApiResponse(
                        new RequestStatus(true),
                        jsonResponse
                    );
                }
            }
            catch (Exception ex)
            {
                return new ApiResponse(
                    new RequestStatus(false),
                    ex.Message
                );
            }
        }
    }
}
