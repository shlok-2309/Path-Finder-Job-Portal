using System.ComponentModel.DataAnnotations;

namespace PathFinder.Model;

public class Catagory{
    public int Id { get; set; }
    
    [Required(ErrorMessage ="Please enter Name")]
    public string Name { get; set; }
    
    
    [Required(ErrorMessage ="Please enter Slug e.g remote-jobs")]
    public string Slug { get; set; }
    
    [Required(ErrorMessage ="Please enter Description")]
    public string Description { get; set; }
}