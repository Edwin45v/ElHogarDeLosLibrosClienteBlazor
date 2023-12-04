using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElHogarLibros.ClienteBlazor.Models;

namespace ElHogarLibros.ClienteBlazor.Services
{
    public interface ILibroService
    {
        Task<IEnumerable<Libro>> GetAll();
        Task<Libro> GetById(int id);
    }
}
