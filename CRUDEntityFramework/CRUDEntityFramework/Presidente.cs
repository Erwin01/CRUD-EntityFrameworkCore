using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEntityFramework
{
    public class Presidente
    {
        [Key]
        public string Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        
    }
}
