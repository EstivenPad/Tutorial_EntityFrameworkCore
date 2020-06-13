using System;
using Tutorial_EntityFrameworkCore.CUD;
using Tutorial_EntityFrameworkCore.Models;

namespace Tutorial_EntityFrameworkCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            Console.WriteLine("Menu:");
            
            Console.WriteLine("1. Insert Data.");
            Console.WriteLine("2. Update Data.");
            Console.WriteLine("3. Delete Data.");

            Console.Write("Seleccione una opcion:");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 0:
                    CUD.CUD.Create();
                    Console.WriteLine("Libro agregado correctamente.");
                    break;

                case 1:
                    CUD.CUD.Update();
                    Console.WriteLine("Libro modificado correctamente.");
                    break;

                case 2:
                    CUD.CUD.Create();
                    Console.WriteLine("Libro eliminado correctamente.");
                    break;
            }
            
        }
    }
}
