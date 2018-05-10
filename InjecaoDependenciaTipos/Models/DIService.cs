using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InjecaoDependenciaTipos.Models
{
    public class DIService
    {
        private readonly IScoped scoped;
        private readonly ITransient transient;
        private readonly ISingleton singleton;

        public DIService(IScoped scoped, ITransient transient, ISingleton singleton)
        {
            this.scoped = scoped;
            this.transient = transient;
            this.singleton = singleton;
        }


    }
}
