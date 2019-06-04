using System;
using System.Collections.Generic;

namespace Catering_Santa_Lucia.Models
{
    public partial class TipoPedido
    {
        public TipoPedido()
        {
            Pedido = new HashSet<Pedido>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
