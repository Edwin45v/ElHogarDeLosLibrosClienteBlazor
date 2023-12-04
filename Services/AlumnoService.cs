using ElHogarLibros.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Net.Http.Json;

namespace ElHogarLibros.ClienteBlazor.Services
{
    public class AlumnoService : IAlumnoService
    {
        private readonly HttpClient httpClient;
        public AlumnoService(HttpClient httpClient)
        {
            httpClient = httpClient;
        }
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public async Task<IEnumerable<Alumno>> GetAll()
        {
            string resp = await httpClient.GetStringAsync($"Alumno");
            return JsonSerializer.Deserialize<IEnumerable<Alumno>>(resp, options);
        }

        public async Task<IEnumerable<Alumno>> GetByAlumno(int idGrado)
        {
            var resp = await httpClient.PostAsJsonAsync($"Alumno/Buscar", new { idGrado = idGrado });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Alumno>>(respString, options);
        }

        public async Task<Alumno> GetById(int id)
        {
            string resp = await httpClient.GetStringAsync($"Alumno/{id}");
            return JsonSerializer.Deserialize<Alumno>(resp, options);
        }
    }
}
