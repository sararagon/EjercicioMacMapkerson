using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacMapkerson.ComponentesCaballeria
{
    class TanqueAtaqueBuilder : Builder.ComponenteBuilder, InterfacesComponentes.ICaballería,
        InterfacesUtilidades.IDestructor, InterfacesUtilidades.IBlindado, InterfacesUtilidades.IMovil
    {
        public string Modelo { get; set; } 
        public double Pf { get; set; } 
        public double Cm { get; set; } 
        public double Bl { get; set; } 
        public int Precio { get; set; } = 15600;

        public override void AñadirUtilidades()
        {
            (c as InterfacesUtilidades.IDestructor).Pf = 9.8;
            (c as InterfacesUtilidades.IMovil).Cm = 7.3;
            (c as InterfacesUtilidades.IBlindado).Bl = 4.8;
        }

        public override void DefinirComponente()
        {
            c = new Builder.Componente(15600);
        }

        public override void DefinirTipo()
        {
            (c as InterfacesComponentes.ICaballería).Modelo = "Sombras-VB98";
        }
    }
}
