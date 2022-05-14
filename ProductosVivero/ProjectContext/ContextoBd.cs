using Microsoft.EntityFrameworkCore;
using ProductosVivero.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductosVivero.ProjectContext
{
    public class ContextoBd : DbContext
    {
        public ContextoBd(DbContextOptions<ContextoBd> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Items>(eb =>
            {
                eb.HasKey(c => new { c.Id });
            });

            modelBuilder.Entity<LoginAdmin>(eb =>
            {
                eb.HasKey(c => new { c.Id });
            });
        }

        public DbSet<Items> Items { get; set; }
        public DbSet<LoginAdmin> LoginAdmin { get; set; }
    }
}
