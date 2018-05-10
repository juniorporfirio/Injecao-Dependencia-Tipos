using System;

namespace InjecaoDependenciaTipos.Models
{
    public class Transient : ITransient
    {
        public Guid Identificador { get; }

        public Transient()
        {
            Identificador = Guid.NewGuid();
        }
    }
}
