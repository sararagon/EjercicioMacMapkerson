using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MacMapkerson.InterfacesComponentes;

namespace MacMapkerson.UtilidadesEjercito
{
    class Ejercito : UtilidadesEjercito.IEjercito
    {
        public int NumElementos { get; set; }
        public List<IComponente> Componentes { get; set; }
        public double Pf { get; set; }
        public double Bl { get; set; }
        public double Cm { get; set; }
        public double CM { get; set; }
        public int Precio { get; set; }

        public void Añadir(InterfacesComponentes.IComponente componente)
        {
            Componentes.Add(componente);
            NumElementos++;
            Algoritmos.IAlgoritmo Cuenta;
            UtilidadesEjercito.Algoritmos.CalculoDatos.CalcularDatos(this);
            UtilidadesEjercito.Algoritmos.CalculoCM.CalcularCM(this);

        }


 

        public void Quitar(InterfacesComponentes.IComponente componente)
        {
            Componentes.Remove(componente);
            NumElementos--;
            UtilidadesEjercito.Algoritmos.CalculoDatos.CalcularDatos(this);
            UtilidadesEjercito.Algoritmos.CalculoCM.CalcularCM(this);
        }
    }
}
