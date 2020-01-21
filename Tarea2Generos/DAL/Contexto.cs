using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea2Generos.Entidades;

namespace Tarea2Generos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Generos> Generos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            base.OnConfiguring(optionsBuilder);
           optionsBuilder.UseSqlServer(@"Server = (local); Database = Tarea2Generos; Trusted_Connection = True;");
        }
    }
}
