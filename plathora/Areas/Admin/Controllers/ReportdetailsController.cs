using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using plathora.Models;
using plathora.pagination;
using plathora.Persistence;
using plathora.Services;
using plathora.Utility;
namespace plathora.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class ReportdetailsController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly ISP_Call _sP_Call;
        public ReportdetailsController(  ApplicationDbContext db, ISP_Call sP_Call)
        {
            _sP_Call = sP_Call;
            _db = db;

        }

        public IEnumerable<SelectListItem> GetAllAffilate()
        {
            var parameter = new DynamicParameters();
           // parameter.Add("@name", name);

            var obj = _sP_Call.List<AffilateListViewModel>("AffilateList", parameter);

            // IEnumerable<SelectListItem> myGenericEnumerable = (IEnumerable<SelectListItem>)obj;

            IEnumerable<SelectListItem> listt= obj.Select(emp => new SelectListItem()
            {
                Text = emp.name,
                Value = emp.Id.ToString()
            });
          
             
            return listt;
        }
        [HttpGet]
        public async Task<IActionResult> collectionReport(int? PageNumber, string from1, string to1, string deliveryboyid)
        {




           // List<SelectList> cl = new List<SelectList>();
            // cl = (from c in _auc.country select c).ToList();

            //List<SelectListItem> mySkills = new List<SelectListItem>() {

            //ViewData["MySkills"] = mySkills;
           // IEnumerable<AffilateListViewModel> obj = GetAllAffilate();
           ViewData["affilatelist"]  = GetAllAffilate();
            //ViewBag.affilatelist  = GetAllAffilate(); 

            ViewBag.deliveryboyid1 = deliveryboyid;
            if(from1==null||from1=="")
            {
                from1 = "01/01/2020";
            }
            if (to1 == null || to1 == "")
            {
                to1 = "01/01/2021";
            }
            ViewBag.from1 = from1;
            ViewBag.to1 = to1;
            //ViewBag.status1 = status;



            var paramter = new DynamicParameters();

            DateTime l1 = DateTime.ParseExact(from1, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime l2 = DateTime.ParseExact(to1, "dd/MM/yyyy", CultureInfo.InvariantCulture);


            paramter.Add("@from", l1);
            paramter.Add("@to", l2);
            paramter.Add("@affilateId", deliveryboyid);
            var orderheaderList1 = _sP_Call.List<collectionreport_affilateViewModel>("collectionReport", paramter);

            //  return View(orderheaderList1.ToList());
            int PageSize = 10;

             
              
            return View(collectionreport_affilatePagination<collectionreport_affilateViewModel>.Create(orderheaderList1.ToList(), PageNumber ?? 1, PageSize));


        }

        [HttpPost]
        public async Task<IActionResult> collectionReport(int? PageNumber, string from1, string to1, string search, string ExcelFileDownload, string deliveryboyid)
        {


            //IEnumerable<SelectListItem> obj = GetAllAffilate();
            // ViewData["deliveryboylist"] = obj;
            // ViewBag.affilatelist = obj;
            // ViewBag.affilatelist = GetAllAffilate();
            ViewData["affilatelist"] = GetAllAffilate();
            //---------------------------------------------
            ViewBag.from1 = from1;
            ViewBag.to1 = to1;

            ViewBag.deliveryboyid1 = deliveryboyid;


            if (search != null)
            {
                
                var paramter = new DynamicParameters();

                DateTime l1 = DateTime.ParseExact(from1, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime l2 = DateTime.ParseExact(to1, "dd/MM/yyyy", CultureInfo.InvariantCulture);


                paramter.Add("@from", l1);
                paramter.Add("@to", l2);
                paramter.Add("@affilateId", deliveryboyid);
                var orderheaderList1 = _sP_Call.List<collectionreport_affilateViewModel>("collectionReport", paramter);

                //  return View(orderheaderList1.ToList());
                int PageSize = 10;

                return View(collectionreport_affilatePagination<collectionreport_affilateViewModel>.Create(orderheaderList1.ToList(), PageNumber ?? 1, PageSize));
                 
            }
            else if (ExcelFileDownload != null)
            {
                /*
                var paramter = new DynamicParameters();

                DateTime l1 = DateTime.ParseExact(from1, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime l2 = DateTime.ParseExact(to1, "dd/MM/yyyy", CultureInfo.InvariantCulture);


                paramter.Add("@from", l1);
                paramter.Add("@to", l2);
                paramter.Add("@deliveryboyid", deliveryboyid);
                var orderheaderList1 = _ISP_Call.List<amtcollectionReportViewModel>("amtcollectionReport", paramter);

                string deliveryname = _driverRegistrationServices.GetById(deliveryboyid).name;


                var builder = new StringBuilder();
                builder.AppendLine("Date,Amount");
                decimal tot_amt = 0;

                foreach (var item in orderheaderList1)
                {
                    tot_amt += item.amount;

                    builder.AppendLine($"{item.date1 },{item.amount}");
                }
                builder.AppendLine($" {"Total :"},{tot_amt }");
                string namee = deliveryname + "_collectionReport.csv";
                return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", namee);
                */
            }


            else
            {
                return View();
            }


            return View();
        }


        //--------advertise---------------------------------------

        [HttpGet]
        public async Task<IActionResult> AdvertiseReport(int? PageNumber, string from1, string to1, string deliveryboyid)
        {




            // List<SelectList> cl = new List<SelectList>();
            // cl = (from c in _auc.country select c).ToList();

            //List<SelectListItem> mySkills = new List<SelectListItem>() {

            //ViewData["MySkills"] = mySkills;
            // IEnumerable<AffilateListViewModel> obj = GetAllAffilate();
            //  ViewData["deliveryboylist"] = obj;
            //  ViewBag.affilatelist = GetAllAffilate();
            ViewData["affilatelist"] = GetAllAffilate();
            ViewBag.deliveryboyid1 = deliveryboyid;
            if (from1 == null || from1 == "")
            {
                from1 = "01/01/2020";
            }
            if (to1 == null || to1 == "")
            {
                to1 = "01/01/2021";
            }
            ViewBag.from1 = from1;
            ViewBag.to1 = to1;
            //ViewBag.status1 = status;



            var paramter = new DynamicParameters();

            DateTime l1 = DateTime.ParseExact(from1, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime l2 = DateTime.ParseExact(to1, "dd/MM/yyyy", CultureInfo.InvariantCulture);


            paramter.Add("@from", l1);
            paramter.Add("@to", l2);
            paramter.Add("@affilateId", deliveryboyid);
            var orderheaderList1 = _sP_Call.List<AdvertisecollectionReportSPModel>("AdvertisecollectionReportSP", paramter);

            //  return View(orderheaderList1.ToList());
            int PageSize = 10;



            return View(collectionreport_affilatePagination<AdvertisecollectionReportSPModel>.Create(orderheaderList1.ToList(), PageNumber ?? 1, PageSize));


        }

        [HttpPost]
        public async Task<IActionResult> AdvertiseReport(int? PageNumber, string from1, string to1, string search, string ExcelFileDownload, string deliveryboyid)
        {


            //IEnumerable<SelectListItem> obj = GetAllAffilate();
            // ViewData["deliveryboylist"] = obj;
            // ViewBag.affilatelist = obj;
            // ViewBag.affilatelist = GetAllAffilate();
            ViewData["affilatelist"] = GetAllAffilate();
            //---------------------------------------------
            ViewBag.from1 = from1;
            ViewBag.to1 = to1;

            ViewBag.deliveryboyid1 = deliveryboyid;


            if (search != null)
            {

                var paramter = new DynamicParameters();

                DateTime l1 = DateTime.ParseExact(from1, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime l2 = DateTime.ParseExact(to1, "dd/MM/yyyy", CultureInfo.InvariantCulture);


                paramter.Add("@from", l1);
                paramter.Add("@to", l2);
                paramter.Add("@affilateId", deliveryboyid);
                var orderheaderList1 = _sP_Call.List<AdvertisecollectionReportSPModel>("AdvertisecollectionReportSP", paramter);

                //  return View(orderheaderList1.ToList());
                int PageSize = 10;

                return View(collectionreport_affilatePagination<AdvertisecollectionReportSPModel>.Create(orderheaderList1.ToList(), PageNumber ?? 1, PageSize));

            }
            else if (ExcelFileDownload != null)
            {
                /*
                var paramter = new DynamicParameters();

                DateTime l1 = DateTime.ParseExact(from1, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime l2 = DateTime.ParseExact(to1, "dd/MM/yyyy", CultureInfo.InvariantCulture);


                paramter.Add("@from", l1);
                paramter.Add("@to", l2);
                paramter.Add("@deliveryboyid", deliveryboyid);
                var orderheaderList1 = _ISP_Call.List<amtcollectionReportViewModel>("amtcollectionReport", paramter);

                string deliveryname = _driverRegistrationServices.GetById(deliveryboyid).name;


                var builder = new StringBuilder();
                builder.AppendLine("Date,Amount");
                decimal tot_amt = 0;

                foreach (var item in orderheaderList1)
                {
                    tot_amt += item.amount;

                    builder.AppendLine($"{item.date1 },{item.amount}");
                }
                builder.AppendLine($" {"Total :"},{tot_amt }");
                string namee = deliveryname + "_collectionReport.csv";
                return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", namee);
                */
            }


            else
            {
                return View();
            }


            return View();
        }
        //-----------------------------------------------

        [HttpGet]
        public async Task<IActionResult> businessOwnerReport(int? PageNumber, string from1, string to1, string deliveryboyid)
        {




            // List<SelectList> cl = new List<SelectList>();
            // cl = (from c in _auc.country select c).ToList();

            //List<SelectListItem> mySkills = new List<SelectListItem>() {

            //ViewData["MySkills"] = mySkills;
            // IEnumerable<AffilateListViewModel> obj = GetAllAffilate();
            //  ViewData["deliveryboylist"] = obj;
            //ViewBag.affilatelist = GetAllAffilate();
            ViewData["affilatelist"] = GetAllAffilate();
            ViewBag.deliveryboyid1 = deliveryboyid;
            if (from1 == null || from1 == "")
            {
                from1 = "01/01/2020";
            }
            if (to1 == null || to1 == "")
            {
                to1 = "01/01/2021";
            }
            ViewBag.from1 = from1;
            ViewBag.to1 = to1;
            //ViewBag.status1 = status;



            var paramter = new DynamicParameters();

            DateTime l1 = DateTime.ParseExact(from1, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime l2 = DateTime.ParseExact(to1, "dd/MM/yyyy", CultureInfo.InvariantCulture);


            paramter.Add("@from", l1);
            paramter.Add("@to", l2);
            paramter.Add("@affilateId", deliveryboyid);
            var orderheaderList1 = _sP_Call.List<BusinessownercollectionReportSPModel>("BusinessownercollectionReportSP", paramter);

            //  return View(orderheaderList1.ToList());
            int PageSize = 10;



            return View(collectionreport_affilatePagination<BusinessownercollectionReportSPModel>.Create(orderheaderList1.ToList(), PageNumber ?? 1, PageSize));


        }

        [HttpPost]
        public async Task<IActionResult> businessOwnerReport(int? PageNumber, string from1, string to1, string search, string ExcelFileDownload, string deliveryboyid)
        {


            //IEnumerable<SelectListItem> obj = GetAllAffilate();
            // ViewData["deliveryboylist"] = obj;
            // ViewBag.affilatelist = obj;
            // ViewBag.affilatelist = GetAllAffilate();
            ViewData["affilatelist"] = GetAllAffilate();
            //---------------------------------------------
            ViewBag.from1 = from1;
            ViewBag.to1 = to1;

            ViewBag.deliveryboyid1 = deliveryboyid;


            if (search != null)
            {

                var paramter = new DynamicParameters();

                DateTime l1 = DateTime.ParseExact(from1, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime l2 = DateTime.ParseExact(to1, "dd/MM/yyyy", CultureInfo.InvariantCulture);


                paramter.Add("@from", l1);
                paramter.Add("@to", l2);
                paramter.Add("@affilateId", deliveryboyid);
                var orderheaderList1 = _sP_Call.List<BusinessownercollectionReportSPModel>("BusinessownercollectionReportSP", paramter);

                //  return View(orderheaderList1.ToList());
                int PageSize = 10;

                return View(collectionreport_affilatePagination<BusinessownercollectionReportSPModel>.Create(orderheaderList1.ToList(), PageNumber ?? 1, PageSize));

            }
            else if (ExcelFileDownload != null)
            {
                /*
                var paramter = new DynamicParameters();

                DateTime l1 = DateTime.ParseExact(from1, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime l2 = DateTime.ParseExact(to1, "dd/MM/yyyy", CultureInfo.InvariantCulture);


                paramter.Add("@from", l1);
                paramter.Add("@to", l2);
                paramter.Add("@deliveryboyid", deliveryboyid);
                var orderheaderList1 = _ISP_Call.List<amtcollectionReportViewModel>("amtcollectionReport", paramter);

                string deliveryname = _driverRegistrationServices.GetById(deliveryboyid).name;


                var builder = new StringBuilder();
                builder.AppendLine("Date,Amount");
                decimal tot_amt = 0;

                foreach (var item in orderheaderList1)
                {
                    tot_amt += item.amount;

                    builder.AppendLine($"{item.date1 },{item.amount}");
                }
                builder.AppendLine($" {"Total :"},{tot_amt }");
                string namee = deliveryname + "_collectionReport.csv";
                return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", namee);
                */
            }


            else
            {
                return View();
            }


            return View();
        }



    }
}
