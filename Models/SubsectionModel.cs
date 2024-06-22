using System.ComponentModel.DataAnnotations;

namespace learning_management_system.Models{
  public class SubsectionModel {
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Title { get; set; }
    // Foreign keys
    public int CourseId { get; set; }

    // Navigation properties
    public CourseModel Course { get; set; }
    public List<VideoModel> Videos { get; set; }
  }
}