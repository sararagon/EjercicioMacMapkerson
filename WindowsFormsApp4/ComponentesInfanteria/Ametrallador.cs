using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacMapkerson.ComponentesInfanteria
{
    class Ametrallador : InterfacesComponentes.IInfanteria,
        InterfacesUtilidades.IMovil, InterfacesUtilidades.IDestructor
    {
        public double Pf { get; set; } = 10;
        public double Cm { get; set; } = 4;
        public int Precio { get; set; } = 400;
    }
}
