using System.ComponentModel.DataAnnotations;

namespace CRUDEntityFramework
{
    public class Pais
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Poblation { get; set; }

        public virtual Continente Continente { get; set; }

    }
}
