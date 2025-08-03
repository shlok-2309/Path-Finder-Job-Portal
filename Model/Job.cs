using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathFinder.Model;

public class Job{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Please enter name")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "Please enter catagory")]
    public string Nature { get; set; }
    
    [Required(ErrorMessage = "Please enter Salary")]
    public String Salary { get; set; }
    
    [Required(ErrorMessage = "Please enter Last Date to Apply")]
    public String LastDateToApply { get; set; }
    
    [Required(ErrorMessage = "Please enter Location")]
    public string Location { get; set; }
    
    public String? Image { get; set; }
    
    [NotMapped]
    public IFormFile Photo { get; set; }
    
}