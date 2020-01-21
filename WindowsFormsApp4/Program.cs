using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacMapkerson
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Boolean fin = false;
            while (!fin)
            {

                Console.WriteLine("Inserta el número de la opción que desee: ");
                Console.WriteLine();
                
                Console.WriteLine("1. Crea un ejercito ");
                Console.WriteLine("2. Añade una unidad \"sanitario\"");
                Console.WriteLine("3. Añade una unidad \"tanque\"");
                Console.WriteLine("4. Añade una unidad \"cañon\"");
                Console.WriteLine("5. Añade una unidad \"Infantería Básica\"");
                Console.WriteLine("6. Añade una unidad \"Transporte\"");
                Console.WriteLine("7. Añade una unidad \"Torpedero Movil\"");
                Console.WriteLine("8. Quita la última unidad añadida");
                Console.WriteLine("9. Muestra la información del ejercito");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":

                    case "2":

                    case "3":

                    case "4":

                    default:
                        Console.WriteLine(UtilidadesEjercito;
                }
            }
        }
    }
}
