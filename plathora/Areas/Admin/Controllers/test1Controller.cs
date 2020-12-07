using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace plathora.Controllers
{
    [Area("Admin")]
    public class test1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}