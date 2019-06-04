using System;
using System.Collections.Generic;

namespace Catering_Santa_Lucia.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Pedido = new HashSet<Pedido>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }

        public string Grupo { get; set; }

        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
