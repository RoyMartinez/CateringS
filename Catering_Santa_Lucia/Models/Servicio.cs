using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Catering_Santa_Lucia.Models
{
    public partial class Servicio
    {
        public Servicio()
        {
            PlatoServicio = new HashSet<PlatoServicio>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? Tipo { get; set; }
        [DisplayName("Tipo")]
        public virtual TipoServicio TipoNavigation { get; set; }
        public virtual ICollection<PlatoServicio> PlatoServicio { get; set; }
    }
}
