using Microsoft.EntityFrameworkCore;
using learning_management_system.Models;

namespace learning_management_system.Data {
  public class ApplicationDbContext : DbContext {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}

    public DbSet<CourseModel> Courses { get; set; }
    public DbSet<UserModel> Users { get; set; }
  }
}