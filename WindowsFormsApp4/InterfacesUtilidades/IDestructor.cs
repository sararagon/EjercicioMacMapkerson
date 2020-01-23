using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson.InterfacesUtilidades{
    public interface IDestructor : InterfacesComponentes.IComponente, InterfacesUtilidades.IUtilidadesComponentes
    {
        double Pf { get; set; }
       
    }
}