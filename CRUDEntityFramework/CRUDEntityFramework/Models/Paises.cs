using System;
using System.Collections.Generic;

namespace CRUDEntityFramework.Models
{
    public partial class Paises
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ContinenteId { get; set; }
        public string Poblation { get; set; }

        public virtual Continentes Continente { get; set; }
    }
}
