using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacMapkerson.ComponentesArtilleria
{
    class CañonAntiaereo : InterfacesComponentes.IArtillería, InterfacesUtilidades.IDestructor,
        InterfacesUtilidades.IMovil
    {
        public double Pf { get; set; } = 22;
        public double Cm { get; set; } = 1;
        public int Precio { get; set; } = 1100;
    }
}
