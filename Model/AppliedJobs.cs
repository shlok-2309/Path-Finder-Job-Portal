using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathFinder.Model;

public class AppliedJobs
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter Full Name")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please enter email")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Please enter contact no.")]
    public string Phone { get; set; }

    [Required(ErrorMessage = "Please enter experience")]
    public String Experience { get; set; }

    [Required(ErrorMessage = "Please enter qualification")]
    public String Qualification { get; set; }

    [Required(ErrorMessage = "Please enter Percentage")]
    public string Percentage { get; set; }
    public string AppliedFor { get; set; }

    public String? Resume { get; set; }

    [NotMapped]
    public IFormFile CV { get; set; }
}