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
        private readonly AppDbContext _db;
        
        public MakeController(AppDbContext db)
        {
            _db = db;
        }
        
        public IActionResult Index()
        {
            return View(_db.Makes.ToList());
        }
    }
}
