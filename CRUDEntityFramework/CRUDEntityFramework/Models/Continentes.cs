using System;
using System.Collections.Generic;

namespace CRUDEntityFramework.Models
{
    public partial class Continentes
    {
        public Continentes()
        {
            Paises = new HashSet<Paises>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Paises> Paises { get; set; }
    }
}
