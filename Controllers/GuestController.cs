using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuestList.Models;
using Microsoft.AspNetCore.Mvc;

namespace GuestList.Controllers
{
    public class GuestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FormGuest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FormGuest(Guest g)
        {
            Repository.AddGuest(g);
            return View("Thanks", g);
        }

        public IActionResult List()
        {
            return View(Repository.AllGuest().Where(guest => guest.Status == true));
        }

        public IActionResult Thanks()
        {
            return View();
        }
    }
}