using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DreyBikeShop.Models;

namespace DreyBikeShop.Controllers
{
    public class MakeController : Controller
    {
        //url - make/bikes
        public IActionResult Bikes()
        {
            Make make = new Make { Id = 1, Name = "Harley Davidson" };
            return View(make);
        }
    }
}
