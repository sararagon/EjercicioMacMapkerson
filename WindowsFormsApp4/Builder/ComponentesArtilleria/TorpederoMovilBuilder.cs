using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacMapkerson.ComponentesArtilleria
{
    class TorpederoMovilBuilder : Builder.ComponenteBuilder, InterfacesComponentes.IArtillería, InterfacesUtilidades.IBlindado, InterfacesUtilidades.IDestructor,
        InterfacesUtilidades.IMovil
    {
        public double Pf { get; set; } 
        public double Cm { get; set; } 
        public double Bl { get; set; } 
        public int Precio { get; set; } 

        public override void AñadirUtilidades()
        {
            (c as InterfacesUtilidades.IDestructor).Pf = 19;
            (c as InterfacesUtilidades.IMovil).Cm = 3;
            (c as InterfacesUtilidades.IBlindado).Bl = 2;
        }

        public override void DefinirComponente()
        {
            c = new Builder.Componente(1350);
        }

        public override void DefinirTipo()
        {
           
        }
    }
}
