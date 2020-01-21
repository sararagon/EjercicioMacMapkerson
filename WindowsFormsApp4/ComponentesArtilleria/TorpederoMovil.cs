using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacMapkerson.ComponentesArtilleria
{
    class TorpederoMovil : InterfacesComponentes.IArtillería, InterfacesUtilidades.IBlindado, InterfacesUtilidades.IDestructor,
        InterfacesUtilidades.IMovil
    {
        public double Pf { get; set; } = 19;
        public double Cm { get; set; } = 3;
        public double Bl { get; set; } = 2;
        public int Precio { get; set; } = 1350;

    }
}
