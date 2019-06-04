using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Catering_Santa_Lucia.Models
{
    public partial class Menu
    {
        public Menu()
        {
            PedidoMenus = new HashSet<PedidoMenus>();
            PlatoServicio = new HashSet<PlatoServicio>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? Tipo { get; set; }
        [DisplayName("Tipo")]
        public virtual TipoMenu TipoNavigation { get; set; }
        public virtual ICollection<PedidoMenus> PedidoMenus { get; set; }
        public virtual ICollection<PlatoServicio> PlatoServicio { get; set; }
    }
}
