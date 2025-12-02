using Microsoft.EntityFrameworkCore;
using Server.DAL.Models.Entities;
using Server.DAL.Models.Entities.Educators;

namespace Server.DAL.Context.ApplicationDbContext;


public class EducatorDbContext : DbContext
{
    public EducatorDbContext(DbContextOptions<EducatorDbContext> options) : base(options)
    { }
    
    public DbSet<Educator> Educators { get; set; }
    public DbSet<EducatorAdditionalInfo> EducatorAdditionalInfos { get; set; }
    public DbSet<EducatorDiscipline> EducatorDisciplines { get; set; }
    public DbSet<Discipline> Disciplines { get; set; }
    
    /// <summary>
    /// Связи БД через EF
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Educator - EducatorAdditionalInfo
        modelBuilder.Entity<Educator>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.HasOne(e => e.EducatorAdditionalInfo)
                .WithOne()
                .HasForeignKey<EducatorAdditionalInfo>(eai => eai.EducatorId);
        });

        // EducatorAdditionalInfo - EducatorDiscipline
        modelBuilder.Entity<EducatorDiscipline>(entity =>
        {
            entity.HasKey(ed => ed.Id);
            
            entity.HasOne<EducatorAdditionalInfo>()
                .WithMany(eai => eai.EducatorDisciplines)
                .HasForeignKey(ed => ed.EducatorAdditionalInfoId);
            entity.HasOne(ed => ed.Discipline)
                .WithMany()
                .HasForeignKey(ed => ed.DisciplineId);
        });
    }
        
}
