using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tutorial_EntityFrameworkCore.Models;

namespace Tutorial_EntityFrameworkCore.CUD
{
    public class CUD
    {
        public static void Create()
        {
            using (var contexto = new Contexto())
            {
                var libro = new Libro()
                {
                    Titulo = "Padre rico, padre pobre",
                    Autor = "Robert Kiyosaki",
                    Genero = "Autoayuda"
                };

                contexto.Libro.Add(libro);
                contexto.SaveChanges();
            }
        }

        public static void Update()
        {
            using (var contexto = new Contexto())
            {
                var libro = contexto.Libro.First<Libro>();
                libro.Autor = "Estiven de Jesus Padilla Santos";
                contexto.SaveChanges();
            }
        }

        public static void Delete()
        {
            using (var contexto = new Contexto())
            {
                var libro = contexto.Libro.First<Libro>();
                contexto.Libro.Remove(libro);
                contexto.SaveChanges();
            }
        }
    }
}
