using System;
using System.Collections.Generic;

namespace Catering_Santa_Lucia.Models
{
    public partial class Mesero
    {
        public Mesero()
        {
            Horario = new HashSet<Horario>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Horario> Horario { get; set; }
    }
}
