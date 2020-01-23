using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MacMapkerson.InterfacesComponentes;

namespace MacMapkerson.UtilidadesEjercito.Algoritmos
{
    class CalculoDatos 
    {
        public static void CalcularDatos(UtilidadesEjercito.IEjercito ejercito)
        {
          
            foreach ( var componente in ejercito.Componentes)
            {
                if(componente is InterfacesUtilidades.IDestructor)
                {
                    ejercito.Pf += (componente as InterfacesUtilidades.IDestructor).Pf;
                }
                if (componente is InterfacesUtilidades.IBlindado)
                {
                    ejercito.Bl += (componente as InterfacesUtilidades.IBlindado).Bl;
                }
                if (componente is InterfacesUtilidades.IMovil)
                {
                    ejercito.Cm += (componente as InterfacesUtilidades.IMovil).Cm;
                }
                ejercito.Precio += componente.Precio;
            }
           
        }
    }
}
