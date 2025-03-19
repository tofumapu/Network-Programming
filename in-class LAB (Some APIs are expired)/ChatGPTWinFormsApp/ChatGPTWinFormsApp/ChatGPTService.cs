using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTWinFormsApp
{
    internal class ChatGPTService : IDisposable
    {
        private readonly HttpClient _client;
        private readonly string _apiKey;
        private const string _apiUrl = "https://api.gemini.com/v1/some_endpoint"; // Thay đổi với endpoint của Gemini

        public ChatGPTService(string apiKey)
        {
            _apiKey = apiKey;
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _apiKey);
        }

        // Phương thức gửi yêu cầu đến Gemini API
        public async Task<dynamic> SendMessageAsync(string message)
        {
            var requestBody = new
            {
                prompt = message, // Thay đổi tùy thuộc vào yêu cầu của API
                max_tokens = 100 // Điều chỉnh số lượng token
            };

            var json = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            try
            {
                var response = await _client.PostAsync(_apiUrl, content);
                response.EnsureSuccessStatusCode();

                var result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<dynamic>(result);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
                return null;
            }
        }

        // Phương thức để đóng HttpClient nếu cần
        public void Dispose()
        {
            _client.Dispose();
        }
    }
}
