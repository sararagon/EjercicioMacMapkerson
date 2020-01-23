using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacMapkerson.Builder
{
    public class ComponenteDirector
    {
        private ComponenteBuilder _builder;

        public ComponenteDirector(ComponenteBuilder builder)
        {
            this._builder = builder;
        }
        public void ConstruirComponente()
        {
            _builder.DefinirComponente();
            _builder.DefinirTipo();
            _builder.AñadirUtilidades();
            
        }

        public Componente GetComponente()
        {
            return _builder.GetComponente();
        }

    }
}
