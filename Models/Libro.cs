﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElHogarLibros.ClienteBlazor.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string Categoria { get; set; }
        public string Imagen { get; set; }
    }
}
