using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

namespace Common.Extensions
{
    public static class HttpClientExtensions
    {
        public static async Task<(T, HttpStatusCode)> PostJsonAsync<T>(
            this HttpClient client,
            string url,
            T obj,
            Action<HttpClient> editFunc = null)
        {
            T result = default(T);

            if (editFunc != null)
                editFunc(client);

            var response = await client.PostAsJsonAsync(url, obj);
            if (!response.IsSuccessStatusCode) return (result, response.StatusCode);
            var stream = await response.Content.ReadAsStreamAsync();
            result = await JsonSerializer.DeserializeAsync<T>(stream);

            return (result, response.StatusCode);
        }

        public static async Task<T> ReadFromJson<T>(this HttpResponseMessage response)
        {
            var stream = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }
    }
}
