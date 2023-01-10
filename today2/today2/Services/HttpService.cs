using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TodayTest.Models.Image;

namespace TodayTest.Services
{
    public static class HttpService
    {
        private const string HttpClientUrl = "https://picsum.photos/v2/list?page=2&limit=10";
        public static async Task<List<ImageModel>> GetImagesASync()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "MyApp"); //ne ja
            var response = await httpClient.GetAsync(HttpClientUrl);
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<List<ImageModel>>(jsonString);
                return result;
            }

            return null;
        }
    }
}