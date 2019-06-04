using System;
using System.Collections.Generic;

namespace Catering_Santa_Lucia.Models
{
    public partial class TipoServicio
    {
        public TipoServicio()
        {
            Servicio = new HashSet<Servicio>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Servicio> Servicio { get; set; }
    }
}
