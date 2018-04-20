using Core.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Domain.Models.Context
{
    public partial class AgendaContext : DbContext
    {
        public virtual DbSet<Evento> Eventoes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var setting = @"Data Source=EST179D\SQLEXPRESS;Initial Catalog=Agenda;Integrated Security=True";
                optionsBuilder.UseSqlServer(setting);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evento>(entity =>
            {
                entity.ToTable("Evento");
                entity.Property(e => e.Descricao).HasMaxLength(50);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuario");
                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.Nome).HasMaxLength(50);
            });
        }
    }
}
