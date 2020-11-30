using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using plathora.Models;
using Microsoft.AspNetCore.Authorization;

using plathora.Utility;
using plathora.Services;
using Dapper;
using plathora.Models.Dtos;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace plathora.Controllers
{
    [Area("Admin")]
   // [Authorize(Roles = SD.Role_Admin)]
    public class HomeController : Controller
    {
       // private readonly ILogger<HomeController> _logger;
        private readonly ISP_Call _sP_Call;
        public HomeController(ILogger<HomeController> logger, ISP_Call sP_Call)
        {
            //_logger = logger;
            _sP_Call = sP_Call;
        }
        [HttpGet]
        public IActionResult Index()
        {
            try
            {


                var parameter = new DynamicParameters();
              //  parameter.Add("@businessid", businessid);
               // var obj = _sP_Call.List<selectallBusinessDetailsDtos>("selectallBusinessDetails", null );
                IEnumerable<selectallBusinessDetailsDtos> obj = _sP_Call.List<selectallBusinessDetailsDtos>("selectallBusinessDetails", null);
                  
                return View(obj);
              

            }
            catch (Exception obj)
            {
                
            }
            return View();
        }
        
        [HttpGet]
        public IActionResult business(string  id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@Id", id);

            getBusinessAllInfo obj = _sP_Call.OneRecord<getBusinessAllInfo>("selectallBusinessDetailsAllInfo", parameter);

            return View(obj);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult about()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
