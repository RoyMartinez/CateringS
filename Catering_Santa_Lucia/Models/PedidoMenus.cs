using System;
using System.Collections.Generic;

namespace Catering_Santa_Lucia.Models
{
    public partial class PedidoMenus
    {
        public int Pedido { get; set; }
        public int Menu { get; set; }

        public virtual Menu MenuNavigation { get; set; }
        public virtual Pedido PedidoNavigation { get; set; }
    }
}
