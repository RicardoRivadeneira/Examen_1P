using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Estudiante
    {
        // Propiedades de la clase Estudiante
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Calificacion { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // Crea un objeto de tipo Estudiante llamado estudiante1
            Estudiante estudiante1 = new Estudiante
            {
                Nombre = "Jose Imbaquinga",
                Edad = 23,
                Calificacion = 14.5
            };

            // Imprime en la consola la información del estudiante.
            Console.WriteLine("Información del Estudiante:");
            Console.WriteLine($"Nombre: {estudiante1.Nombre}");
            Console.WriteLine($"Edad: {estudiante1.Edad} años");
            Console.WriteLine($"Calificación: {estudiante1.Calificacion}");

            Console.ReadKey();
        }
    }
}
