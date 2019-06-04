using System;
using System.Collections.Generic;

namespace Catering_Santa_Lucia.Models
{
    public partial class Horario
    {
        public int Pedido { get; set; }
        public int Mesero { get; set; }
        public int? Cantidad { get; set; }

        public virtual Mesero MeseroNavigation { get; set; }
        public virtual Pedido PedidoNavigation { get; set; }
    }
}
