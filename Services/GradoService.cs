using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using ElHogarLibros.ClienteBlazor.Models;
using System.Text.Json;

namespace ElHogarLibros.ClienteBlazor.Services
{
    public class GradoService : IGradoService
    {
        private readonly HttpClient _httpClient;
        public GradoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Grado>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Grado");
            return JsonSerializer.Deserialize<IEnumerable<Grado>>(resp, options);
        }
    }
}
