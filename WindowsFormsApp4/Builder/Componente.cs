using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacMapkerson.Builder
{
    public class Componente : InterfacesComponentes.IComponente
    {
        public int Precio { get; set; }

        public Componente(int precio)
        {
            this.Precio = precio;
        }


    }
}
