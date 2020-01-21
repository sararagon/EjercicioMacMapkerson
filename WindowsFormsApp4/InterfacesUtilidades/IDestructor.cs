using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson.InterfacesUtilidades{
    public interface IDestructor : InterfacesComponentes.IComponente
    {
        double Pf { get; set; }
       
    }
}