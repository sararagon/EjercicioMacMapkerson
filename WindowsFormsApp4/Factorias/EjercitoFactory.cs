using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson.Factorias
{
    public class EjercitoFactory
    {
        public static UtilidadesEjercito.Ejercito CrearEjercito()
        {
            return new UtilidadesEjercito.Ejercito();
        }

        
        
    }
}