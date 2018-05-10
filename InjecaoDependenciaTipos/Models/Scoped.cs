using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InjecaoDependenciaTipos.Models
{
    public class Scoped : IScoped
    {
        public Guid Identificador { get; }

        public Scoped()
        {
            Identificador = Guid.NewGuid();
        }
    }
}
