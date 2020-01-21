using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacMapkerson.UtilidadesEjercito.Algoritmos
{
    class CalculoCM : UtilidadesEjercito.Algoritmos.ICalculoCM
    {
        public void CalcularCM(UtilidadesEjercito.IEjercito ejercito)
        {
            if (ejercito.Pf == 0)
            {
                ejercito.Pf = 1;
            }
            if (ejercito.Cm == 0)
            {
                ejercito.Cm = 1;
            }
            if (ejercito.Bl == 100)
            {
                ejercito.Pf = 99;
            }
            ejercito.CM = (ejercito.Pf *(ejercito.Cm /2)/(100- ejercito.Bl));
        }
    }
}
