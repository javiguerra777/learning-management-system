using System.ComponentModel.DataAnnotations;

namespace learning_management_system.Models{
  public class UserModel {
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string FullName { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string PasswordHash { get; set; }

    public int Points { get; set;}

    // Navigation properties
    public List<UserCourse> UserCourses { get; set; }
  }

  public class UserCourse {
    public int UserId { get; set; }
    public UserModel User { get; set; }

    public int CourseId { get; set; }
    public CourseModel Course { get; set; }
  }
}