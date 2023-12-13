using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main()
        {
            // Paso 1: Declarar dos variables, numero1 y numero2, e inicialízalas con valores numéricos.
            int numero1 = 10;
            int numero2 = 15;

            // Paso 2: Calcula la suma de estas dos variables y almacena el resultado en una tercera variable llamada resultado.
            int resultado = numero1 + numero2;

            // Paso 3: Imprime en la consola el valor de resultado.
            Console.WriteLine("La suma de {0} y {1} es: {2}", numero1, numero2, resultado);

            // Espera a que el usuario presione una tecla antes de cerrar la aplicación (opcional).
            Console.ReadKey();


        }
    }
}
