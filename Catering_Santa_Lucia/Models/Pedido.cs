using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Catering_Santa_Lucia.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            Horario = new HashSet<Horario>();
            PedidoMenus = new HashSet<PedidoMenus>();
        }

        public int Id { get; set; }
        [DisplayName("Fecha Creacion")]
        public DateTime? FechaCreacion { get; set; }
        [DisplayName("Fecha Entrega")]
        public DateTime? FechaPedido { get; set; }
        public int? Tipo { get; set; }
        public int? Cliente { get; set; }
        public int? Usuario { get; set; }
        [DisplayName("Cliente")]
        public virtual Cliente ClienteNavigation { get; set; }
        [DisplayName("Tipo")]
        public virtual TipoPedido TipoNavigation { get; set; }
        [DisplayName("Usuario Grabo")]
        public virtual Usuario UsuarioNavigation { get; set; }
        public virtual ICollection<Horario> Horario { get; set; }
        public virtual ICollection<PedidoMenus> PedidoMenus { get; set; }
    }
}
