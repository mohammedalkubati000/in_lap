using in_lap.Data;
using in_lap.Models;
using Microsoft.AspNetCore.Mvc;

namespace in_lap.Controllers
{
    public class EmployeesController : Controller
    {


        //DI
        private readonly AppDbContext _db;
        public EmployeesController(AppDbContext db)
        {
            _db = db;

        }



        public ActionResult Index()
        {
            //Entity Framework Approach

            IEnumerable<Employee> employees = _db.Employees.ToList();
            return View(employees);
        }

        //public ActionResult Index()
        //{
        //    //Adoo.Net Approach
        //    var sql = "SELECT * FROM Employees";
        //    var employees = _db.Employees.FromSqlRaw(sql).ToList();
        //    return View(employees);
        //}


        //public ActionResult Index()
        //{


        //    IList<Employee> employees = new List<Employee>
        //    {
        //        new Employee { Id = 1, Name = "Alice", Position = "Developer", Salary = 60000 },
        //        new Employee { Id = 2, Name = "Bob", Position = "Manager", Salary = 80000 },
        //        new Employee { Id = 3, Name = "Charlie", Position = "Tester", Salary = 50000 }
        //    };

        //    return View(employees);
        //}
    }
}  
