using Microsoft.EntityFrameworkCore;
using learning_management_system.Models;

namespace learning_management_system.Data {
  public class ApplicationDbContext : DbContext {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}
    public DbSet<UserModel> Users { get; set; }
    public DbSet<CourseModel> Courses { get; set; }
    public DbSet<SubsectionModel> Subsections { get; set; }
    public DbSet<VideoModel> Videos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
      base.OnModelCreating(modelBuilder);

      // Configure the composite key for UserCourse
      modelBuilder.Entity<UserCourse>()
        .HasKey(uc => new { uc.UserId, uc.CourseId });
    }
  }
}