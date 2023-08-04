using Hotel.Data;
using Hotel.Migrations;
using Hotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class GuestController : Controller
    {

        private readonly ApplicationDbContext _db;

        public GuestController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {


            return View();
        }


        [HttpGet]
        public IActionResult Reservation()
        {


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Reservation(Guest guest)
        {
            

            if(ModelState.IsValid)
            {
                var email = _db.Guests.FirstOrDefault(u => u.Email == guest.Email);
                if (email != null)
                {
                    ModelState.AddModelError("AllreadyThere", "Email address allraedy exists");
                }
                if(email.Phone_number == guest.Phone_number)
                {
                    ModelState.AddModelError("AllreadyThere", "Phone number allraedy exists");
                }
                _db.Guests.Add(guest);
                _db.SaveChanges();
            }


            return View();
        }


    }
}
