using System.Text;
using System.Text.Json;

namespace SmartTrade.Infrastructure
{
    public static class HttpClientJsonExtensions
    {
        public static Task<HttpResponseMessage> PostJsonAsync<TValue>(this HttpClient client, string requestUri, TValue value, CancellationToken cancellationToken = default)
        {
            var json = JsonSerializer.Serialize(value);
            var content = new StringContent(content: json, encoding: Encoding.UTF8, "application/json");
            return client.PostAsync(requestUri: requestUri, content, cancellationToken: cancellationToken);
        }
    }
}
