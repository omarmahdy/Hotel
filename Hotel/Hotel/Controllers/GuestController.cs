using Hotel.Data;
using Hotel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Hotel.Controllers
{
    public class GuestController : Controller
    {

        private readonly ApplicationDbContext _db;
        public GuestController(ApplicationDbContext db)
        {
            _db = db;   
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Reservation1()
        {
           

            return View();
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Reservation1(Guest guest)
        {
            var email = _db.Guests.FirstOrDefault(u => u.Email == guest.Email);
            if (email != null)
            {
                ModelState.AddModelError("Exists", "Email address Allready exists");
            }

            if (ModelState.IsValid)
            {
                _db.Guests.Add(guest);
                _db.SaveChanges();
                return RedirectToAction("Index","Home");   

            }
            return View();
        }




    }
}
