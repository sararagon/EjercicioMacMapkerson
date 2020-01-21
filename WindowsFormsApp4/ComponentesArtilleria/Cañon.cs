using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson.ComponentesArtilleria
{
    public class Cañon : InterfacesComponentes.IArtillería, InterfacesUtilidades.IDestructor
    {
        public double Pf { get; set; } = 14;
        public int Precio { get; set; } = 1100;
        
    }
}