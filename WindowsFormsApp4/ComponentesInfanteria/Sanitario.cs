using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacMapkerson.ComponentesInfanteria
{
    class Sanitario : InterfacesComponentes.IInfanteria, InterfacesUtilidades.IMovil
    {
        public double Cm { get; set; } = 7;
        public int Precio { get; set; } = 500;
    }
}
