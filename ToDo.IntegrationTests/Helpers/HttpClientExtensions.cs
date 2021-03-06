using System.Net.Http;
using System.Net.Http.Headers;

namespace ToDo.IntegrationTests.Helpers
{
    public static class HttpClientExtensions
    {
        public static void AddCookie(this HttpClient client, string key, string value)
        {
            client.DefaultRequestHeaders.Add("Cookie", $"{key}={value};");
        }

        public static void AddAuthenticationToken(this HttpClient client, string token)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public static void Authenticate(this HttpClient httpClient)
        {
            AddAuthenticationToken(httpClient, AccessToken.Valid);
        }
    }
}