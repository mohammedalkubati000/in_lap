using in_lap.Data;
using in_lap.Models;
using Microsoft.AspNetCore.Mvc;

namespace in_lap.Controllers
{
    public class DepartmentsController : Controller
    {

        //DI 
        private readonly AppDbContext _db;
        public DepartmentsController(AppDbContext db)
        {
            _db = db;
        }


        public ActionResult Index()
        {
            //Entity Framework Approach
            IEnumerable<Department> depts = _db.Departments.ToList();
            return View(depts);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                _db.Departments.Add(department);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Please fill all the required fields.");
            return View(department);

        }


        //===============
        //Edit
        //==========================
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var dept = _db.Departments.Find(Id);
            if (dept == null)
            {
                return NotFound();
            }

            return View(dept);
        }

        [HttpPost]
        public ActionResult Edit(Department department)
        {
            if (ModelState.IsValid)
            {
                _db.Departments.Update(department);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Please fill all the required fields.");
            return View(department);

        }


        //===============
        //Delete
        //==========================
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var dept = _db.Departments.Find(Id);
            if (dept == null)
            {
                return NotFound();
            }

            return View(dept);
        }

        [HttpPost]
        public ActionResult Delete(Department department)
        {

            _db.Departments.Remove(department);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }


    }
}
