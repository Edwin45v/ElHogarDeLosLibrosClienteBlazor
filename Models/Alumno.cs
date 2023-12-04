using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElHogarLibros.ClienteBlazor.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        public int GradoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Imagen { get; set; }
    }
}
