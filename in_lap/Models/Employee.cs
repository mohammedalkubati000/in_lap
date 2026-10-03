using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace in_lap.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string Email { get; set; } = "";
        public string Position { get; set; }
        public decimal Salary { get; set; } = 0;
        public string Description { get; internal set; }
       
        


    }
}
