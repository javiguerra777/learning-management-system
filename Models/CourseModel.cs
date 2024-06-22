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
    public string DisplayImageUrl { get; set; }

    [Required]
    public int CompletionTime { get; set; }

    [Required]
    public int Rating { get; set; }
    public int NumberOfRatings { get; set; }

    // Navigation properties
    public List<UserCourse> UserCourses { get; set; }
    public List<SubsectionModel> Subsections { get; set; }
    
  }
}