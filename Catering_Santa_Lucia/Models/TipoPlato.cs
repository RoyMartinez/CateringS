using System;
using System.Collections.Generic;

namespace Catering_Santa_Lucia.Models
{
    public partial class TipoPlato
    {
        public TipoPlato()
        {
            Plato = new HashSet<Plato>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Plato> Plato { get; set; }
    }
}
