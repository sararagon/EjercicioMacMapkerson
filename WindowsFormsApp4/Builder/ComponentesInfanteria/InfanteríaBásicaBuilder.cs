﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacMapkerson.ComponentesInfanteria
{
    class InfanteríaBásicaBuilder : Builder.ComponenteBuilder, InterfacesComponentes.IInfanteria,
        InterfacesUtilidades.IMovil, InterfacesUtilidades.IDestructor
    {
        public double Pf { get; set; } 
        public double Cm { get; set; } 
        public int Precio { get; set; } 

        public override void AñadirUtilidades()
        {
            (c as InterfacesUtilidades.IDestructor).Pf = 7;
            (c as InterfacesUtilidades.IMovil).Cm = 6;
        }

        public override void DefinirComponente()
        {
            c = new Builder.Componente(250);
        }

        public override void DefinirTipo()
        {
           
        }
    }
}
