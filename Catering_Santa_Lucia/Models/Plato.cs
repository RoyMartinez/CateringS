using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Catering_Santa_Lucia.Models
{
    public partial class Plato
    {
        public Plato()
        {
            PlatoServicio = new HashSet<PlatoServicio>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? Tipo { get; set; }
        [DisplayName("Tipo")]
        public virtual TipoPlato TipoNavigation { get; set; }
        public virtual ICollection<PlatoServicio> PlatoServicio { get; set; }
    }
}
