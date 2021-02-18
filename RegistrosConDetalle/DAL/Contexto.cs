using Microsoft.EntityFrameworkCore;
using RegistrosConDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistrosConDetalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Ordenes> Ordenes { get; set; }
        public DbSet<OrdenesDetalle> OrdenesDetalle { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = GestionOrdenes.Db");
        }

        
    }
}
