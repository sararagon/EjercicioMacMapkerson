using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacMapkerson.ComponentesCaballeria
{
    class TanqueAtaque: InterfacesComponentes.ICaballería,
        InterfacesUtilidades.IDestructor, InterfacesUtilidades.IBlindado, InterfacesUtilidades.IMovil
    {
        public string Modelo { get; set; } = "Sombras-VB98";
        public double Pf { get; set; } = 9.8f;
        public double Cm { get; set; } = 7.3f;
        public double Bl { get; set; } = 4.8f;
        public int Precio { get; set; } = 15600;
    }
}
