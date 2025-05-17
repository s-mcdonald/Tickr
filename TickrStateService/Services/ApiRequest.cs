using System.Text.Json;

namespace TickrStateService.Services
{
    public class ApiRequest
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public static async Task<T> GetAsync<T>(string endpoint)
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(endpoint);
                response.EnsureSuccessStatusCode();

                string jsonString = await response.Content.ReadAsStringAsync();

                // Debug
                Console.WriteLine("JSON response:");
                Console.WriteLine(jsonString);

                T? result = JsonSerializer.Deserialize<T>(jsonString, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return result == null ? throw new Exception("Failed to deserialize JSON response.") : result;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Request error: {ex.Message}");
                throw;
            }
        }
    }
}
