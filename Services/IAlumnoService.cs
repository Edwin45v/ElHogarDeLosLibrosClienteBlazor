using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElHogarLibros.ClienteBlazor.Models;

namespace ElHogarLibros.ClienteBlazor.Services
{
    public interface IAlumnoService
    {
        Task<IEnumerable<Alumno>> GetAll();
        Task<IEnumerable<Alumno>> GetByAlumno(int idGrado);
        Task<Alumno> GetById(int id);
    }
}
