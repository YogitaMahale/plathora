using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace plathora.Controllers
{
    public class advertisementtestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}