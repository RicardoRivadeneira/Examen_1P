using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{

    class Program
    {
        static void Main()
        {
            // Crea un objeto de tipo EstudianteGraduado llamado graduado1 e inicializa sus propiedades.
            EstudianteGraduado graduado1 = new EstudianteGraduado
            {
                Nombre = "Ricardo Rivadeneria",
                Edad = 20,
                Calificacion = 17,
                Titulo = "Ingeniería en Software"
            };

            // Utiliza el método MostrarInformacion de la clase base para mostrar la información del estudiante graduado.
            Console.WriteLine("\t**Ejercicio 5**");
            Console.WriteLine("Información del Estudiante Graduado:");
            graduado1.MostrarInformacion();
            Console.WriteLine($"Título obtenido: {graduado1.Titulo}");

            Console.ReadKey();
        }
    }
}
