using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson.InterfacesUtilidades
{
    public interface IMovil : InterfacesComponentes.IComponente, InterfacesUtilidades.IUtilidadesComponentes
    {
        double Cm { get; set; }
    }
}