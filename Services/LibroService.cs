using ElHogarLibros.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ElHogarLibros.ClienteBlazor.Services
{
    public class LibroService : ILibroService
    {
        private readonly HttpClient httpClient;
        public LibroService(HttpClient httpClient)
        {
            httpClient = httpClient;
        }
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public Task<Libro> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Libro>> GetAll()
        {
            string resp = await httpClient.GetStringAsync($"Libro");
            return JsonSerializer.Deserialize<IEnumerable<Libro>>(resp, options);
        }
    }
}
