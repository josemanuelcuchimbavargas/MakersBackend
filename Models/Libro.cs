using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Libro
    {
        public Libro()
        {
            this.IdLibro = Guid.NewGuid();
        }

        [Key]
        public Guid IdLibro { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string Titulo { get; set; }

        [Required]        
        public Guid IdEditoria { get; set; }

        [Required]        
        public DateTime Fecha { get; set; }

        [Required]
        public Decimal Costo { get; set; }

        [Required]
        public Decimal PrecioSugerido { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string Autor { get; set; }

    }
}
