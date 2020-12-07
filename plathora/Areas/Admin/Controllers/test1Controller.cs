using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using appFoodDelivery.Services.Implementation;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using plathora.Entity;
using plathora.Models;
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
        [HttpPost]
        public string MobileView(string mobileNo)
        {
            String no = null;
            Random random = new Random();
            for (int i = 0; i < 1; i++)
            {
                int n = random.Next(0, 999);
                no += n.ToString("D4") + "";
            }
            #region "sms"
            try
            {

                string Msg = "OTP :" + no + ".  Please Use this OTP.This is usable once and expire in 10 minutes";

                string OPTINS = "STRLIT";

                string type = "3";
                string strUrl = "https://www.bulksmsgateway.in/sendmessage.php?user=ezacus&password=" + "ezacus@2020" + "&message=" + Msg.ToString() + "&sender=" + OPTINS + "&mobile=" + mobileNo + "&type=" + 3;

                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                System.Net.WebRequest request = System.Net.WebRequest.Create(strUrl);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream s = (Stream)response.GetResponseStream();
                StreamReader readStream = new StreamReader(s);
                string dataString = readStream.ReadToEnd();
                response.Close();
                s.Close();
                readStream.Close();
                //    Response.Write("Sent");
            }

            catch
            { }
            #endregion

            return "complete";
        }

        [HttpPost]
        public IActionResult MobileView1(string mobileNo)
        {

            return View();
        }

    }
}