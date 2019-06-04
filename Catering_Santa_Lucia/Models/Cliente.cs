using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Catering_Santa_Lucia.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Pedido = new HashSet<Pedido>();
        }

        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Encargado { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public int? Tipo { get; set; }
        [DisplayName("Tipo")]
        public virtual TipoCliente TipoNavigation { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
