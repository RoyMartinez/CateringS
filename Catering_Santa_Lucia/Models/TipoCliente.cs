using System;
using System.Collections.Generic;

namespace Catering_Santa_Lucia.Models
{
    public partial class TipoCliente
    {
        public TipoCliente()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
