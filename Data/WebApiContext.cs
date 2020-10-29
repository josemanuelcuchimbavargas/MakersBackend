using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class WebApiContext : DbContext
    {
        public WebApiContext (DbContextOptions<WebApiContext> options)
            : base(options)
        {
        }

        public DbSet<WebApi.Models.Editorial> Editorial { get; set; }

        public DbSet<WebApi.Models.Libro> Libro { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Editorial>().HasData(
                new Editorial { Nombre = "Almadía" },
                new Editorial { Nombre = "Acantilado" },
                new Editorial { Nombre = "Aguilar" },
                new Editorial { Nombre = "Akal" },
                new Editorial { Nombre = "Alba" }
                );
        }
     
    }
}
