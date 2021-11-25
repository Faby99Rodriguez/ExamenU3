using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3.Models
{
    internal class ApplicatiionDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Database=Libreria; Username=postgres; Password=nada12")
               .EnableSensitiveDataLogging(true);
        }

        public DbSet<Alumno> Alumno { get; set; }

        public DbSet<Libro> Libro { get; set; }

        public DbSet<Bibliotecario> Bibliotecario { get; set; }

    }
}
