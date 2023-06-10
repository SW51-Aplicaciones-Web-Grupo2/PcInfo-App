using Microsoft.EntityFrameworkCore;
using PCInfo_backend.Recommendations.Domain.Models;
using PCInfo_backend.Shared.Extensions;
using Monitor = PCInfo_backend.Recommendations.Domain.Models.Monitor;

namespace PCInfo_backend.Shared.Persistence.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }

    
    public DbSet<User>? Users { get; set; }
    public DbSet<Cliente>? Clientes { get; set; }
    //hacer model

    public DbSet<Producto>? Productos { get; set; }
    
    public DbSet<CPU>? CPUs { get; set; }
    public DbSet<DiscoDuro>? DiscosDuros { get; set; }
    public DbSet<GPU>? GPUs { get; set; }
    public DbSet<Monitor>? Monitors { get; set; }
    public DbSet<Mouse>? Mouses { get; set; }
    public DbSet<RAM>? RAMs { get; set; }
    public DbSet<Teclado>? Teclados { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>().ToTable("usuario");
        modelBuilder.Entity<User>().HasKey(u => u.IDuser);
        modelBuilder.Entity<User>().Property(u => u.IDuser).IsRequired().ValueGeneratedOnAdd();
        modelBuilder.Entity<User>().Property(u => u.Usuario).IsRequired().HasMaxLength(50);
        
        modelBuilder.Entity<Cliente>().ToTable("cliente");
        modelBuilder.Entity<Cliente>().HasKey(c => c.DNI);
        modelBuilder.Entity<Cliente>().Property(c => c.DNI).IsRequired().ValueGeneratedOnAdd();
        modelBuilder.Entity<Cliente>().Property(c => c.Nombre).IsRequired().HasMaxLength(50);
        //Relationships
        modelBuilder.Entity<Cliente>()
            .HasOne(c => c.user)
            .WithOne()
            .HasForeignKey<Cliente>(c => c.IDuser);
        
        
        /*modelBuilder.Entity<Producto>().ToTable("Productos");
        modelBuilder.Entity<Producto>().HasKey(p => p.Codigo);
        modelBuilder.Entity<Producto>().Property(p => p.Codigo).IsRequired().ValueGeneratedOnAdd();
        modelBuilder.Entity<Producto>().Property(p => p.Nombre).IsRequired().HasMaxLength(30);
        
        modelBuilder.Entity<CPU>().ToTable("CPU");
        modelBuilder.Entity<CPU>().HasKey(c => c.id);
        //Relationships
        modelBuilder.Entity<CPU>()
            .HasOne(c => c.producto)
            .WithOne()
            .HasForeignKey<CPU>(c => c.codigoProducto);

        modelBuilder.Entity<DiscoDuro>().ToTable("DiscoDuro");
        modelBuilder.Entity<DiscoDuro>().HasKey(d => d.id);
        modelBuilder.Entity<DiscoDuro>()
            .HasOne(d => d.producto)
            .WithOne()
            .HasForeignKey<DiscoDuro>(d => d.codigoProducto);
        
        modelBuilder.Entity<GPU>().ToTable("GPU");
        modelBuilder.Entity<GPU>().HasKey(g => g.id);
        modelBuilder.Entity<GPU>()
            .HasOne(g => g.producto)
            .WithOne()
            .HasForeignKey<GPU>(g => g.codigoProducto);
        
        modelBuilder.Entity<Monitor>().ToTable("Monitor");
        modelBuilder.Entity<Monitor>().HasKey(m => m.id);
        modelBuilder.Entity<Monitor>()
            .HasOne(m => m.producto)
            .WithOne()
            .HasForeignKey<Monitor>(m => m.codigoProducto);
        
        modelBuilder.Entity<Mouse>().ToTable("Mouse");
        modelBuilder.Entity<Mouse>().HasKey(m => m.id);
        modelBuilder.Entity<Mouse>()
            .HasOne(m => m.producto)
            .WithOne()
            .HasForeignKey<Mouse>(m => m.codigoProducto);
        
        modelBuilder.Entity<RAM>().ToTable("RAM");
        modelBuilder.Entity<RAM>().HasKey(r => r.id);
        modelBuilder.Entity<RAM>()
            .HasOne(r => r.producto)
            .WithOne()
            .HasForeignKey<RAM>(r => r.codigoProducto);
        
        modelBuilder.Entity<Teclado>().ToTable("Teclado");
        modelBuilder.Entity<Teclado>().HasKey(t => t.id);
        modelBuilder.Entity<Teclado>()
            .HasOne(t => t.producto)
            .WithOne()
            .HasForeignKey<Teclado>(t => t.codigoProducto);*/
        
        // Apply Snake Case Naming Convention
        modelBuilder.UseSnakeCaseNamingConvention();
    }
}