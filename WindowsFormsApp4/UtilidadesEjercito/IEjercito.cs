using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacMapkerson.UtilidadesEjercito
{
    interface IEjercito
    {
        int NumElementos { get; set; }
        List<InterfacesComponentes.IComponente> Componentes { get; set; }
        double Pf { get; set; }
        double Bl { get; set; }
        double Cm { get; set; }
        double CM { get; set; }
        int Precio { get; set; }
        
        void Añadir(InterfacesComponentes.IComponente componente);
        void Quitar(InterfacesComponentes.IComponente componente);
        void Quitar();


    }
}
