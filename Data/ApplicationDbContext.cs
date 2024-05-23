using Microsoft.EntityFrameworkCore;

namespace learning_management_system.Data {
  public class ApplicationDbContext : DbContext {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}
  }
}