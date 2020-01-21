using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacMapkerson.UtilidadesEjercito.Algoritmos
{
    interface ICalculoCM : IAlgoritmo
    {
        void CalcularCM(UtilidadesEjercito.IEjercito ejercito);
    }
}
