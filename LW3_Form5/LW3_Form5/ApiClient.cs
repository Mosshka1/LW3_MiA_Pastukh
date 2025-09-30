using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LW3_Form5
{
    public class ApiClient : IDisposable
    {
        private readonly HttpClient _http;

        public ApiClient(string baseUrl)
        {
            _http = new HttpClient { BaseAddress = new Uri(baseUrl) };
            _http.Timeout = TimeSpan.FromSeconds(15);
        }
        public async Task<List<Film>> GetFilmsAsync()
        {
            using (var resp = await _http.GetAsync("/films"))
            {
                resp.EnsureSuccessStatusCode();
                var json = await resp.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<Film>>(json);
                return list ?? new List<Film>();
            }
        }
        public async Task<Film> GetFilmByIdAsync(string id)
        {
            using (var resp = await _http.GetAsync("/films/" + id))
            {
                resp.EnsureSuccessStatusCode();
                var json = await resp.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Film>(json);
            }
        }
        public void Dispose()
        {
            _http.Dispose();
        }
    }
}
