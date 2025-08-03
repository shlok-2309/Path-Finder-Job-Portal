using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathFinder.Model;

public class Testimonial{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Please enter name")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "Please enter Occupation")]
    public string Occupation { get; set; }
    
    [Required(ErrorMessage = "Please enter Review")]
    public String Review { get; set; }
    
    public String? Image { get; set; }
    
    [NotMapped]
    public IFormFile Photo { get; set; }
}