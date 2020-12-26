using appFoodDelivery.Services;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using plathora.Entity;
using plathora.Services;
using plathora.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace plathora.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]

    public class AdmindashboardController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var paramter = new DynamicParameters();          

            //paramter.Add("@from", l1);
            //paramter.Add("@to", l2);
            //paramter.Add("@affilateId", deliveryboyid);
            var orderheaderList1 = _sP_Call.List<collectionreport_affilateViewModel>("collectionReport", paramter);



            return View();
        }
    }
}
