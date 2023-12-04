using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElHogarLibros.ClienteBlazor.Models;

namespace ElHogarLibros.ClienteBlazor.Services
{
    public interface IGradoService
    {
        Task<IEnumerable<Grado>> GetAll();
    }
}
