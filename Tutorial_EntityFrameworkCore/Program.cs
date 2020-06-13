using System;
using Tutorial_EntityFrameworkCore.Models;

namespace Tutorial_EntityFrameworkCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var contexto = new Contexto())
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
    }
}
