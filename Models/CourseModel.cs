using System.ComponentModel.DataAnnotations;

namespace learning_management_system.Models{
  public class CourseModel {
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Title { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public string Instructor { get; set; }

    [Required]
    public string CourseImage { get; set; }

    [Required]
    public int CourseLength { get; set; }

    [Required]
    public int Rating { get; set; }
    
    // Foreign Key
    public int UserId { get; set; }

    // Navigation property
    public UserModel User { get; set; }
  }
}