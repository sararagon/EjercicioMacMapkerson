using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacMapkerson.ComponentesCaballeria
{
    class TransporteBuilder : Builder.ComponenteBuilder, InterfacesComponentes.ICaballería,
        InterfacesUtilidades.IBlindado, InterfacesUtilidades.IMovil
    {
        public string Modelo { get; set; }
        public double Cm { get; set; }
        public double Bl { get; set; }
        public int Precio { get; set; } 

        public override void AñadirUtilidades()
        {
            (c as InterfacesUtilidades.IMovil).Cm = 4.5;
            (c as InterfacesUtilidades.IBlindado).Bl = 1.4;
        }

        public override void DefinirComponente()
        {
            c = new Builder.Componente(4200);
        }

        public override void DefinirTipo()
        {
            (c as InterfacesComponentes.ICaballería).Modelo = "MX-7899";
        }
    }
}
