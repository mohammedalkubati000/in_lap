using in_lap.Data;
using in_lap.Models;
using Microsoft.AspNetCore.Authorization;
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

            IEnumerable<Employee> depts = _db.Employees.ToList();

            return View(depts);

           
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
   
            if (ModelState.IsValid)
            {
                _db.Employees.Add(employee);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Please fill all the required fields.");
            return View(employee);

        }


        //===============
        //Edit
        //==========================
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var dept = _db.Employees.Find(Id);
            if (dept == null)
            {
                return NotFound();
            }

            return View(dept);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _db.Employees.Update(employee);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Please fill all the required fields.");
            return View(employee);

        }

        //===============
        //Delete
        //==========================
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var emp = _db.Employees.Find(Id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        [HttpPost]
        public ActionResult Delete(Employee employee)
        {
            _db.Employees.Remove(employee);
            _db.SaveChanges();
            return RedirectToAction("Index");
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
