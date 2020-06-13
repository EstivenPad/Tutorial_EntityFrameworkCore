using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tutorial_EntityFrameworkCore.Models
{
    public class Libro
    {
        [Key]
        public int LibroId { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Genero { get; set; }
    }
}
