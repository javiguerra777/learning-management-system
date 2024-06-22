using System.ComponentModel.DataAnnotations;

namespace learning_management_system.Models{
  public class VideoModel {
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Title { get; set; }

    [Required]
    public string VideoUrl { get; set; }

    // Foreign keys
    public int SubsectionId { get; set; }

    // Navigation properties
    public SubsectionModel Subsection { get; set; }
  }
}