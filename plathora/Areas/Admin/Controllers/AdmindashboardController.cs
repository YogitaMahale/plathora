using appFoodDelivery.Services;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using plathora.Entity;
using plathora.Models;
using plathora.Models.Dtos;
using plathora.Persistence;
using plathora.Services;
using plathora.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Mvc;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace plathora.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]

    public class AdmindashboardController : Controller
    {
        private readonly ISP_Call _sP_Call;
        private readonly ApplicationDbContext _db;
        public AdmindashboardController(ISP_Call sP_Call, ApplicationDbContext db)
        {
            _sP_Call = sP_Call;
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            WebsiteDashboard obj = new WebsiteDashboard();
            var paramter = new DynamicParameters();          

            //paramter.Add("@from", l1);
            //paramter.Add("@to", l2);
            //paramter.Add("@affilateId", deliveryboyid);
            obj.objWebsiteDashboardcnt = _sP_Call.OneRecord<WebsiteDashboardSPViewModel>("WebsiteDashboardSP", null);



            return View(obj);
        }

        #region "API CALL"
        [HttpGet]
        public IActionResult GetALLCustomer()
        {
            try
            {
            var paramter = new DynamicParameters();

            //paramter.Add("@from", l1);
            //paramter.Add("@to", l2);
            //paramter.Add("@affilateId", deliveryboyid);
             
            IEnumerable<dashboardCustomerList> obj = _sP_Call.List<dashboardCustomerList>("TodayRegisterCustomer", null);


           
            return Json(new { data = obj.ToList() });
            }
            catch(Exception obj1)
            {
                string s = obj1.Message;
            }
            
            //var obj = _unitofWork.category.GetAll();
            return Json(new { data = "" });
        }
        public IActionResult GetALLAffilate()
        {
            try
            {
                var paramter = new DynamicParameters();

                //paramter.Add("@from", l1);
                //paramter.Add("@to", l2);
                //paramter.Add("@affilateId", deliveryboyid);

                IEnumerable<dashboardCustomerList> obj = _sP_Call.List<dashboardCustomerList>("TodayRegisterAffilate", null);



                return Json(new { data = obj.ToList() });
            }
            catch (Exception obj1)
            {
                string s = obj1.Message;
            }

            //var obj = _unitofWork.category.GetAll();
            return Json(new { data = "" });
        }
        //public ActionResult BarChart()
        //{
        //    var paramter = new DynamicParameters();

        //    //paramter.Add("@from", l1);
        //    //paramter.Add("@to", l2);
        //    //paramter.Add("@affilateId", deliveryboyid);

        //    IEnumerable<dashboardTable> obj = _sP_Call.List<dashboardTable>("dashboardBarchart", null);


        //    return Json(obj.ToList());
        //}
        #endregion
    }
}
