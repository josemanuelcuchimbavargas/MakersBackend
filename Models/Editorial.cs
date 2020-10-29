using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Editorial
    {
        public Editorial()
        {
            this.IdEditoria = Guid.NewGuid();
        }

        [Key]
        public Guid IdEditoria { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Nombre { get; set; }
    }
}
