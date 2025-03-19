using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_23520231_23520249
{
    internal class YoutubeService
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string LinkVideo { get; set; }
        public string ViewCount { get; set; }

        private readonly string apiKey = "AIzaSyDkE-1jMOxu_kV2xdqYA6f9qkPO50TxUp0";
        public async Task<List<YoutubeService>> GetYoutubeTrendingVideos()
        {
            List<YoutubeService> youtubeVideos = new List<YoutubeService>();
            string url = $"https://www.googleapis.com/youtube/v3/videos?part=snippet,statistics&chart=mostPopular&videoCategoryId=10&regionCode=VN&maxResults=50&key={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        dynamic data = JsonConvert.DeserializeObject(json);
                        foreach (var item in data.items)
                        {
                            YoutubeService youtubeVideo = new YoutubeService
                            {
                                Title = item.snippet.title,
                                Description = item.snippet.description,
                                LinkVideo = "https://www.youtube.com/watch?v=" + item.id,
                                ViewCount = item.statistics.viewCount
                            };
                            youtubeVideos.Add(youtubeVideo);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"HTTP Error: {response.StatusCode}");
                        MessageBox.Show("Failed to fetch data. Please check the API Key and Internet connection.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            return youtubeVideos;
        }

    }
}
