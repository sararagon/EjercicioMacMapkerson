using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MacMapkerson.Builder
{
   public abstract class ComponenteBuilder
    {
        protected Builder.Componente c;

        public Builder.Componente GetComponente()
        {
            return c;
        }

        public abstract void DefinirComponente();
        public abstract void DefinirTipo();
        public abstract void AñadirUtilidades();
        

    }
}
