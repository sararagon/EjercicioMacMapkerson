using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacMapkerson.ComponentesInfanteria
{
    class SanitarioBuilder : Builder.ComponenteBuilder, InterfacesComponentes.IInfanteria, InterfacesUtilidades.IMovil
    {
        public double Cm { get; set; } 
        public int Precio { get; set; } 

        public override void AñadirUtilidades()
        {
            (c as InterfacesUtilidades.IMovil).Cm = 7;
        }

        public override void DefinirComponente()
        {
            c = new Builder.Componente(500);
        }

        public override void DefinirTipo()
        {
           
        }
    }
}
