using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace in_lap.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("My Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
    }
}
