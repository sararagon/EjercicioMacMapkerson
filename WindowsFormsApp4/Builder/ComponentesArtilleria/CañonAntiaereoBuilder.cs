using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacMapkerson.ComponentesArtilleria
{
    class CañonAntiaereoBuilder : Builder.ComponenteBuilder, InterfacesComponentes.IArtillería, InterfacesUtilidades.IDestructor,
        InterfacesUtilidades.IMovil
    {
        public double Pf { get; set; }
        public double Cm { get; set; } 
        public int Precio { get; set; }

        public override void AñadirUtilidades()
        {
            (c as InterfacesUtilidades.IDestructor).Pf = 22;
            (c as InterfacesUtilidades.IMovil).Cm = 1;
        }

        public override void DefinirComponente()
        {
            c = new Builder.Componente(1100);
        }

        public override void DefinirTipo()
        {
           
        }
    }
}
