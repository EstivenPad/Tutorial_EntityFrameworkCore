using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tutorial_EntityFrameworkCore.Models;

namespace Tutorial_EntityFrameworkCore
{
    public class Contexto : DbContext
    {
        public DbSet<Libro> Libro { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Prestamo> Prestamo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=BibliotecaDB;Trusted_Connection=True;");
        }
    }
}
