using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MacMapkerson.InterfacesComponentes;

namespace MacMapkerson.ComponentesCaballeria
{
    class TransporteRapido : InterfacesComponentes.ICaballería,
        InterfacesUtilidades.IMovil
    {
        public double Cm { get; set; } = 12;
        public int Precio { get; set; } = 1600;
        public String Modelo { get; set; } = "TAXIN-66";
       
    }
}
