using Microsoft.EntityFrameworkCore;
using Server.DLL.Models.Entities;

namespace Server.DLL.Context.ApplicationDbContext;


public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {
    }
    
    public DbSet<Educator> Educators { get; set; }
    
    /// <summary>
    /// Связи БД через EF
    /// </summary>
    /// <param name="modelBuilder"></param>

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Educator>(entity =>
        {
            entity.ToTable("educators");
            entity.HasKey(e => e.Id);
        
            // Используем точные имена колонок из БД (без кавычек)
            entity.Property(e => e.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd(); // важно для SERIAL
        
            entity.Property(e => e.FullName)
                .HasColumnName("fullname")
                .IsRequired()
                .HasMaxLength(100);
            
            entity.Property(e => e.AcademicDegree)
                .HasColumnName("academicdegree")
                .HasMaxLength(200)
                .IsRequired(false);
            
            entity.Property(e => e.Image)
                .HasColumnName("image")
                .IsRequired(false);
        });
    }

}
