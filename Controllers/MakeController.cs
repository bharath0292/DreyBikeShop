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
        [Route(template:"Make/Bikes")]
        public IActionResult Bikes()
        {
            Make make = new Make { Id = 1, Name = "Harley Davidson" };
            return View(make);
        }

        [Route(template: "make/bikes/{year:int:length(4)}/{month:int:range(1,12)}")]
        public IActionResult ByYearMonth(int year, int month)
        {
            return Content(year+":"+month);
        }
    }
}
