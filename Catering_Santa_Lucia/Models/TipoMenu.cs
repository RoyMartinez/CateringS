using System;
using System.Collections.Generic;

namespace Catering_Santa_Lucia.Models
{
    public partial class TipoMenu
    {
        public TipoMenu()
        {
            Menu = new HashSet<Menu>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Menu> Menu { get; set; }
    }
}
