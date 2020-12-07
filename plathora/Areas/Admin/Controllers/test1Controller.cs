using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using appFoodDelivery.Services.Implementation;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using plathora.Entity;
using plathora.Services;

namespace plathora.Controllers
{
    [Area("Admin")]
    public class test1Controller : Controller
    {
        private ISP_Call _sP_Call;
        private readonly ISubscribeServices _subscribeServices;
        public test1Controller(ISubscribeServices subscribeServices, ISP_Call sP_Call)
        {
            _sP_Call = sP_Call;
            _subscribeServices = subscribeServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string  Add(string email)
        {
            Subscribe obj = new Subscribe();
            obj.id = 0;
            obj.Email = email;


            var parameter = new DynamicParameters();
            parameter.Add("@Email", email);

            _sP_Call.Execute("SubscribeSave", parameter);
            
            return "complete";
        }
    }
}