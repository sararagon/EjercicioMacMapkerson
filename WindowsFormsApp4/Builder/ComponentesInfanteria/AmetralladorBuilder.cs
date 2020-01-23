using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacMapkerson.ComponentesInfanteria
{
    class AmetralladorBuilder : Builder.ComponenteBuilder, InterfacesComponentes.IInfanteria,
        InterfacesUtilidades.IMovil, InterfacesUtilidades.IDestructor
    {
        public double Pf { get; set; } 
        public double Cm { get; set; } 
        public int Precio { get; set; } 

        public override void AñadirUtilidades()
        {
            (c as InterfacesUtilidades.IDestructor).Pf = 10;
            (c as InterfacesUtilidades.IMovil).Cm = 4;
        }

        public override void DefinirComponente()
        {
            c = new Builder.Componente(400);
        }

        public override void DefinirTipo()
        {
            
        }
    }
}
