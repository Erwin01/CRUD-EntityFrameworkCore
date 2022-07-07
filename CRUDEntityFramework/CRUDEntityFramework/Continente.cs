using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUDEntityFramework
{
    public class Continente
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Pais> Paises { get; set; }

        public Continente()
        {
            Paises = new List<Pais>();
        }
    }
}
