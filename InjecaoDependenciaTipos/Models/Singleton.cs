using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InjecaoDependenciaTipos.Models
{
    public class Singleton : ISingleton
    {
        public Guid Identificador { get; }

        public Singleton()
        {
            Identificador = Guid.NewGuid();
        }
    }
}
