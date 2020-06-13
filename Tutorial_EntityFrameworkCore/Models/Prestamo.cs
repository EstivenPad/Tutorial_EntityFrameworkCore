using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tutorial_EntityFrameworkCore.Models
{
    public class Prestamo
    {
        [Key]
        public int PrestamoId { get; set; }

        public int LibroId { get; set; }

        public int ClienteId { get; set; }

        [Required]
        [Column("Fecha de prestamo")]
        public DateTime FechaPrestamo { get; set; }

        [Required]
        [Column("Fecha de devolucion")]
        public DateTime FechaDevolucion { get; set; }

        public Libro Libro { get; set; }

        public Cliente Cliente { get; set; }
    }
}
