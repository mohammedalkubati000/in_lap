using in_lap.Data;
using Microsoft.AspNetCore.Mvc;

namespace in_lap.Controllers
{
    public class UsersController : Controller
    {


        public readonly AppDbContext _db;

        public UsersController(AppDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
         var users = _db.Users.ToList();
            return View(users); 

        }








    }
}
