using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacMapkerson.ComponentesInfanteria
{
    class InfanteríaBásica : InterfacesComponentes.IInfanteria,
        InterfacesUtilidades.IMovil, InterfacesUtilidades.IDestructor
    {
        public double Pf { get; set; } = 7;
        public double Cm { get; set; } = 6;
        public int Precio { get; set; } = 250;
    }
}
