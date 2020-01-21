using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacMapkerson.ComponentesCaballeria
{
    class Transporte : InterfacesComponentes.ICaballería,
        InterfacesUtilidades.IBlindado, InterfacesUtilidades.IMovil
    {
        public string Modelo { get; set; } = "MX-7899";
        public double Cm { get; set; } = 4.5;
        public double Bl { get; set; } = 1.4;
        public int Precio { get; set; } = 4200;
    }
}
