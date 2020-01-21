using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson.InterfacesComponentes
{
    public interface ICaballería : InterfacesComponentes.IComponente
    {
        String Modelo { get; set; }
    }
}