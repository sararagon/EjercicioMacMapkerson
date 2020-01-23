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
            UtilidadesEjercito.Ejercito MiEjercito = null;
            /*String Valores = String.Format();*/
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
                    case "1":  MiEjercito = Factorias.EjercitoFactory.CrearEjercito();
                        break;
                        
                    case "2": MiEjercito.Añadir(new ComponentesInfanteria.SanitarioBuilder());
                        break;

                    case "3":
                        MiEjercito.Añadir(new ComponentesCaballeria.TanqueAtaqueBuilder());
                        break;

                    case "4":
                        MiEjercito.Añadir(new ComponentesArtilleria.CañonBuilder());
                        break;

                    case "5":
                        MiEjercito.Añadir(new ComponentesInfanteria.InfanteríaBásicaBuilder());
                        break;
                    case "6":
                        MiEjercito.Añadir(new ComponentesCaballeria.TransporteBuilder());
                        break;
                    case "7":
                        MiEjercito.Añadir(new ComponentesArtilleria.TorpederoMovilBuilder());
                        break;
                    case "8":
                        MiEjercito.Quitar();
                        break;
                    case "9":
                        Console.WriteLine("El ejercito de {MiEjercito.NumElementos} tiene un CM de {MiEjercito.CM}" +
                "una potencia de fuego de {MiEjercito.Pf}, un Blindade de {MiEjercito.Bl} y una capacidad de movimiento" +
                "de {MiEjercito.Cm}. Se ha gastado {MiEjercito.Precio} € de su presupuesto");
                        break;

                    default:
                        Console.WriteLine("Orden introducida no válida. Finalizando....");
                        fin = true;
                        break;
                }
            }
        }
    }
}
