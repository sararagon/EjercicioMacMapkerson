using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson.ComponentesArtilleria
{
    public class CañonBuilder : Builder.ComponenteBuilder, InterfacesComponentes.IArtillería, InterfacesUtilidades.IDestructor
    {
        public double Pf { get; set; }
        public int Precio { get; set; }

        public override void DefinirComponente()
        {
            c = new Builder.Componente(1100);
        }

        public override void AñadirUtilidades()
        {
            (c as InterfacesUtilidades.IDestructor).Pf = 14;
            
        }
        

        public override void DefinirTipo()
        {
            
        }
    }
}