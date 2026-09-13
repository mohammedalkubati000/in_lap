using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace in_lap.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [DisplayName("Position")]
        [Required(ErrorMessage = "Position is required")]
        public string Position { get; set; }
        [DisplayName("Salary")]
        [Required(ErrorMessage = "Salary is required")]
        public decimal Salary { get; set; } = 0;
        [DisplayName("Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
            
    }
}
