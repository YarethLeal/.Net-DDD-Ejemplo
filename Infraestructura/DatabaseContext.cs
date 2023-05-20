using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Infraestructura
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            //options.UseNpgsql($"Server=163.178.107.7;Port=5432;Database=BDTarea;User Id=laboratorios;Password=saucr.120;");
        }

        public virtual DbSet<Estudiante> Estudiante { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("tarea");
            base.OnModelCreating(modelBuilder);

        }

    }
}