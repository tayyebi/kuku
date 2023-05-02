using Microsoft.EntityFrameworkCore;

namespace Api.Models;

public class DatabaseContext : DbContext
{
    public DatabaseContext()
    {
        
    }
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    public DbSet<Person> People { get; set; } = null!;
    public DbSet<Transcript> Transcripts { get; set; } = null!;
    public DbSet<Project> Projects { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Transcript>()
        .HasMany(e=>e.Attendies)
        .WithMany(e=>e.AttendedSessions)
        .UsingEntity(
            "PersonToTranscriptJoinTable",
            l => l.HasOne(typeof(Person)).WithMany().HasForeignKey("TranscriptId").HasPrincipalKey(nameof(Person.Id)),
            r => r.HasOne(typeof(Transcript)).WithMany().HasForeignKey("PersonId").HasPrincipalKey(nameof(Transcript.Id)),
            j => j.HasKey("PersonId", "TranscriptId"));
    }
}