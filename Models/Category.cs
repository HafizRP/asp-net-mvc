using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace testMvcApp.Models;
public class Category
{
    [Key]
    public int id { get; set; }

    [Required]
    [DisplayName("Username")]
    public string username { get; set; }

    [DisplayName("Display Order")]
    [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100 only")]
    public int DisplayOrder { get; set; }
    
    public DateTime createdAt { get; set; } = DateTime.Now;
}
