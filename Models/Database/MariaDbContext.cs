using Microsoft.EntityFrameworkCore;
using SuperHerois.Entidades;

namespace SuperHerois.Models;

public partial class MariaDbContext : DbContext, IMariaDbContext
{
    private IConfiguration _config;

    public virtual DbSet<Heroi> Herois { get; set; } = null!;

    public MariaDbContext(IConfiguration config)        
    {
        _config = config;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySQL(_config.GetConnectionString("DefaultConnection"));
        }   
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Heroi>(entity =>
        {
            entity.ToTable("heroi");

            entity.Property(e => e.Id).HasColumnType("int(11)");

            entity.Property(e => e.Nome)
                .HasMaxLength(70)
                .HasDefaultValueSql(string.Empty);

            entity.Property(e => e.Poder)
                .HasMaxLength(70)
                .HasDefaultValueSql(string.Empty);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
