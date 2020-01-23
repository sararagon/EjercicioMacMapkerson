using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MacMapkerson.InterfacesComponentes;

namespace MacMapkerson.ComponentesCaballeria
{
    class TransporteRapidoBuilder : Builder.ComponenteBuilder, InterfacesComponentes.ICaballería,
        InterfacesUtilidades.IMovil
    {
        public double Cm { get; set; } 
        public int Precio { get; set; }
        public String Modelo { get; set; } 

        public override void AñadirUtilidades()
        {
            (c as InterfacesUtilidades.IMovil).Cm = 12;

        }

        public override void DefinirComponente()
        {
            c = new Builder.Componente(1600);
        }

        public override void DefinirTipo()
        {
            (c as InterfacesComponentes.ICaballería).Modelo = "TAXIN-66";
        }

    }
}
