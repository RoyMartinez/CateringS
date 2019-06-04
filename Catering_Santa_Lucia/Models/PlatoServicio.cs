using System;
using System.Collections.Generic;

namespace Catering_Santa_Lucia.Models
{
    public partial class PlatoServicio
    {
        public int Plato { get; set; }
        public int Servicio { get; set; }
        public int? Menu { get; set; }
        public string Dia { get; set; }

        public virtual Menu MenuNavigation { get; set; }
        public virtual Plato PlatoNavigation { get; set; }
        public virtual Servicio ServicioNavigation { get; set; }
    }
}
