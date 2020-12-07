using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using plathora.Entity;
using plathora.Models;
using plathora.Models.Dtos;
using plathora.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace plathora.Controllers
{
    [Area("Admin")]
    // [Authorize(Roles = SD.Role_Admin)]
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;
        private readonly ISP_Call _sP_Call;
        private IConfiguration Configuration;
        private ISectorRegistrationServices _SectorRegistrationServices;
        private IBusinessRegistrationServieces _BusinessRegistrationServieces;
        private IProductMasterServices _productMasterServices;
        private IAboutUsServices _aboutUsServices;
        private IContactUsServices _ContactUsServices;
        private IbusinessratingsServices _businessratingsServices;
        private IBusinessOwnerRegiServices _businessOwnerRegiServices;
        private INewsServices _newsServices;
        public HomeController(ILogger<HomeController> logger, ISP_Call sP_Call, IConfiguration _Configuration, ISectorRegistrationServices SectorRegistrationServices, IBusinessRegistrationServieces BusinessRegistrationServieces, IProductMasterServices productMasterServices, IAboutUsServices aboutUsServices, IContactUsServices ContactUsServices, IbusinessratingsServices businessratingsServices, IBusinessOwnerRegiServices businessOwnerRegiServices, INewsServices newsServices)
        {
            //_logger = logger;
            _sP_Call = sP_Call;
            Configuration = _Configuration;
            _SectorRegistrationServices = SectorRegistrationServices;
            _BusinessRegistrationServieces = BusinessRegistrationServieces;
            _productMasterServices = productMasterServices;
            _aboutUsServices = aboutUsServices;
            _ContactUsServices = ContactUsServices;
            _businessratingsServices = businessratingsServices;
            _businessOwnerRegiServices = businessOwnerRegiServices;
            _newsServices = newsServices;
        }
        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                frontwebsiteModel objmodel = new frontwebsiteModel();

                //  ViewBag.search = txtsearch;
                var parameter = new DynamicParameters();

                //IEnumerable<selectallBusinessDetailsDtos> obj = _sP_Call.List<selectallBusinessDetailsDtos>("selectallBusinessDetails", null);
                objmodel.objBusinessDetails = _sP_Call.List<selectallBusinessDetailsDtos>("selectallBusinessDetails", null);
                objmodel.objSectorRegistration = _SectorRegistrationServices.GetAll().Take(12).Select(x => new plathora.Models.SectorRegistrationIndexViewModel
                {
                    id = x.id,
                    name = x.name,
                    img = x.img,
                    photo = x.photo

                }).ToList();

                objmodel.objNews = _newsServices.GetAll().Where(x=>x.isdeleted==false).OrderByDescending(x=>x.id).Select(x => new NewIndexViewModel
                {
                    id = x.id,
                    title = x.title,
                    img = x.img,
                    description = x.description,
                    isdeleted = x.isdeleted,
                    isactive = x.isactive,
                    date1 = x.date1,
                    createddate = x.createddate

                }).ToList();
                return View(objmodel);
            }
            catch (Exception obj)
            {
            }
            return View();
        }

        [HttpPost]
        [ActionName("Index")]
        public IActionResult Index1(string txtsearch)
        {
            try
            {
                ViewBag.search = txtsearch;
                frontwebsiteModel objmodel = new frontwebsiteModel();
                //  ViewBag.search = txtsearch;                var parameter = new DynamicParameters();
                //IEnumerable<selectallBusinessDetailsDtos> obj = _sP_Call.List<selectallBusinessDetailsDtos>("selectallBusinessDetails", null);
                objmodel.objBusinessDetails = _sP_Call.List<selectallBusinessDetailsDtos>("selectallBusinessDetails", null);
                if (txtsearch == null || txtsearch.Trim() == "")
                {
                    objmodel.objSectorRegistration = _SectorRegistrationServices.GetAll().OrderByDescending(x => x.id).Where(x => x.isdeleted == false).Select(x => new plathora.Models.SectorRegistrationIndexViewModel
                    {
                        id = x.id,
                        name = x.name,
                        img = x.img,
                        photo = x.photo

                    }).ToList();
                }
                else
                {
                    objmodel.objSectorRegistration = _SectorRegistrationServices.GetAll().Where(x => x.name.Contains(txtsearch) && x.isdeleted == false).Select(x => new plathora.Models.SectorRegistrationIndexViewModel
                    {
                        id = x.id,
                        name = x.name,
                        img = x.img,
                        photo = x.photo

                    }).ToList();
                }
                objmodel.objNews = _newsServices.GetAll().Where(x => x.isdeleted == false).Select(x => new NewIndexViewModel
                {
                    id = x.id,
                    title = x.title,
                    img = x.img,
                    description = x.description,
                    isdeleted = x.isdeleted,
                    isactive = x.isactive,
                    date1 = x.date1,
                    createddate = x.createddate

                });
                //------------------------------------------------------------------------------------
                /*
                string connString = this.Configuration.GetConnectionString("DefaultConnection");
                SqlConnection con = new SqlConnection(connString);
                try
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "searchquery";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@searchkeyword", searchkeyword);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);

                    if (ds != null)
                    {
                        if (ds.Tables[0].Rows[0]["type"].ToString().ToLower().Trim() == "sector".ToString().ToLower().Trim())
                        {


                            //List<SectorRegistrationIndexViewModel> objList = new List<SectorRegistrationIndexViewModel>();
                            List<search_SectorRegistrationIndexViewModel> objList = new List<search_SectorRegistrationIndexViewModel>();
                            foreach (DataRow _dataRow in ds.Tables[0].Rows)
                            {
                                search_SectorRegistrationIndexViewModel obj = new search_SectorRegistrationIndexViewModel();
                                obj.id = Convert.ToInt32(_dataRow["id"]);
                                obj.name = Convert.ToString(_dataRow["name"]);
                                obj.img = Convert.ToString(_dataRow["img"]);
                                obj.type = Convert.ToString(_dataRow["type"]);
                                objList.Add(obj);

                                //string myJson = "{\"Message\": " + "\"Bad Request\"" + "\"data\"" + "}";
                                //return BadRequest(myJson);
                            }



                            return Ok(objList);
                        }
                        else if (ds.Tables[0].Rows[0]["type"].ToString().ToLower().Trim() == "business".ToString().ToLower().Trim())
                        {
                            //List<BusinessRegistrationIndexViewModel> objList = new List<BusinessRegistrationIndexViewModel>();
                            List<search_BusinessRegistrationIndexViewModel> objList = new List<search_BusinessRegistrationIndexViewModel>();
                            foreach (DataRow _dataRow in ds.Tables[0].Rows)
                            {
                                search_BusinessRegistrationIndexViewModel obj = new search_BusinessRegistrationIndexViewModel();
                                obj.id = Convert.ToInt32(_dataRow["id"]);
                                obj.sectorid = Convert.ToInt32(_dataRow["sectorid"]);
                                obj.name = Convert.ToString(_dataRow["name"]);
                                obj.img = Convert.ToString(_dataRow["img"]);
                                obj.type = Convert.ToString(_dataRow["type"]);
                                objList.Add(obj);
                            }
                            return Ok(objList);
                        }
                        else if (ds.Tables[0].Rows[0]["type"].ToString().ToLower().Trim() == "product".ToString().ToLower().Trim())
                        {

                            //List<ProductIndexViewModel> objList = new List<ProductIndexViewModel>();
                            List<search_ProductIndexViewModel> objList = new List<search_ProductIndexViewModel>();
                            foreach (DataRow _dataRow in ds.Tables[0].Rows)
                            {
                                search_ProductIndexViewModel obj = new search_ProductIndexViewModel();
                                obj.id = Convert.ToInt32(_dataRow["id"]);
                                // obj.sectorid = Convert.ToInt32(_dataRow["sectorid"]);
                                obj.businessid = Convert.ToInt32(_dataRow["businessid"]);
                                obj.productName = Convert.ToString(_dataRow["productName"]);
                                obj.img = Convert.ToString(_dataRow["img"]);
                                obj.type = Convert.ToString(_dataRow["type"]);
                                // obj.BusinessRegistration = null;
                                // obj.SectorRegistration = null;
                                objList.Add(obj);
                            }
                            return Ok(objList);
                        }
                        else if (ds.Tables[0].Rows[0]["type"].ToString().ToLower().Trim() == "businessowner".ToString().ToLower().Trim())
                        {
                            //List<BusinessOwnerRegistrationDtos> objList = new List<BusinessOwnerRegistrationDtos>();
                            List<search_BusinessOwnerRegistrationDtos> objList = new List<search_BusinessOwnerRegistrationDtos>();
                            foreach (DataRow _dataRow in ds.Tables[0].Rows)
                            {
                                search_BusinessOwnerRegistrationDtos obj = new search_BusinessOwnerRegistrationDtos();



                                obj.id = Convert.ToInt32(_dataRow["id"]);
                                obj.name = Convert.ToString(_dataRow["name"]);
                                obj.profilephoto = Convert.ToString(_dataRow["profilephoto"]);
                                obj.mobileno1 = Convert.ToString(_dataRow["mobileno1"]);


                                obj.mobileno2 = Convert.ToString(_dataRow["mobileno2"]);

                                obj.emailid1 = Convert.ToString(_dataRow["emailid1"]);


                                obj.emailid2 = Convert.ToString(_dataRow["emailid2"]);

                                obj.adharcardno = Convert.ToString(_dataRow["adharcardno"]);


                                obj.adharcardphoto = Convert.ToString(_dataRow["adharcardphoto"]);

                                obj.pancardno = Convert.ToString(_dataRow["pancardno"]);


                                obj.pancardphoto = Convert.ToString(_dataRow["pancardphoto"]);
                                obj.password = Convert.ToString(_dataRow["password"]);
                                obj.gender = Convert.ToString(_dataRow["gender"]);
                                obj.pinno = Convert.ToString(_dataRow["pinno"]);
                                obj.DOB = Convert.ToDateTime(_dataRow["DOB"]);

                                obj.house = Convert.ToString(_dataRow["house"]);
                                obj.landmark = Convert.ToString(_dataRow["landmark"]);
                                obj.street = Convert.ToString(_dataRow["street"]);


                                obj.cityid = Convert.ToInt32(_dataRow["cityid"]);
                                obj.zipcode = Convert.ToString(_dataRow["zipcode"]);

                                obj.latitude = Convert.ToString(_dataRow["latitude"]);
                                obj.longitude = Convert.ToString(_dataRow["longitude"]);
                                obj.companyName = Convert.ToString(_dataRow["companyName"]);
                                obj.designation = Convert.ToString(_dataRow["designation"]);
                                obj.gstno = Convert.ToString(_dataRow["gstno"]);
                                obj.Website = Convert.ToString(_dataRow["Website"]);
                                obj.Discription = Convert.ToString(_dataRow["Discription"]);
                                obj.Regcertificate = Convert.ToString(_dataRow["Regcertificate"]);



                                obj.businessid = Convert.ToString(_dataRow["businessid"]);




                                obj.productid = Convert.ToString(_dataRow["productid"]);
                                obj.lic = Convert.ToString(_dataRow["lic"]);
                                obj.registerbyAffilateID = Convert.ToInt32(_dataRow["registerbyAffilateID"]);
                                obj.deviceid = Convert.ToString(_dataRow["deviceid"]);
                                obj.type = Convert.ToString(_dataRow["type"]);

                                objList.Add(obj);
                            }
                            return Ok(objList);
                        }
                        else
                        {
                            string myJson = "{\"Message\": " + "\"Not Found\"" + "}";
                            return NotFound(myJson);
                        }
                    }
                    else
                    {
                        string myJson = "{\"Message\": " + "\"Not Found\"" + "}";
                        return NotFound(myJson);
                    }

                }
                catch
                {
                    string myJson2 = "{\"Message\": " + "\"Not Found\"" + "}";
                    return NotFound(myJson2);
                }
                finally { con.Close(); }
                */

                //--------------------------------------------------------------------------------------
                return View(objmodel);
            }
            catch (Exception obj)
            {

            }
            return View();
            //try
            //{
            //    ViewBag.search = txtsearch;

            //    var parameter = new DynamicParameters();
            //    //  parameter.Add("@businessid", businessid);
            //    // var obj = _sP_Call.List<selectallBusinessDetailsDtos>("selectallBusinessDetails", null );
            //    IEnumerable<selectallBusinessDetailsDtos> obj = _sP_Call.List<selectallBusinessDetailsDtos>("selectallBusinessDetails", null);

            //    return View(obj);


            //}
            //catch (Exception obj)
            //{

            //}
            //return View();
        }





        [HttpGet]
        public IActionResult business(string id)
        {
            businessDetailsViewModel obj = new businessDetailsViewModel();


            var parameter = new DynamicParameters();
            parameter.Add("@Id", id);

            obj.objgetBusinessAllInfo = _sP_Call.OneRecord<getBusinessAllInfo>("selectallBusinessDetailsAllInfo", parameter);

            //var parameter1 = new DynamicParameters();
            //parameter1.Add("@BusinessOwnerId", id);
            obj.objbusinessrating = _sP_Call.List<selectallBusinessRatingViewModel>("selectallBusinessRating", parameter);
            if (obj == null)
            {
                return View();
            }
            else
            {
                return View(obj);

            }



        }

        [HttpGet]
        public IActionResult businessDetails(int sectorid)
        {
            //var obj = _BusinessRegistrationServieces.GetAll().Where(x => x.sectorid == sectorid && x.isdeleted == false).Select(x => new BusinessRegistrationIndexViewModel
            //{
            //    id = x.id,
            //    sectorid = x.sectorid,
            //    name = x.name,
            //    SectorRegistration = _SectorRegistrationServices.GetById(x.sectorid),
            //    img = x.img,
            //    photo = x.photo

            //}).ToList();
            //return View(obj);
            var obj = _BusinessRegistrationServieces.GetAll().Where(x => x.sectorid == sectorid && x.isdeleted == false).ToList();
            return View(obj);
        }
        [HttpGet]
        public IActionResult productDetails(int businessid)
        {
            var obj = _productMasterServices.GetAll().Where(x => x.businessid == businessid && x.isdeleted == false).Select(x => new ProductIndexViewModel
            {


                id = x.id,
                //sectorid = x.se,
                businessid = x.businessid,
                productName = x.productName,
                BusinessRegistration = _BusinessRegistrationServieces.GetById(x.businessid),
                SectorRegistration = _SectorRegistrationServices.GetById(_BusinessRegistrationServieces.GetById(x.businessid).sectorid),
                img = x.img

            }).ToList();
            return View(obj);
        }


        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult about()
        {
            AboutUs obj = _aboutUsServices.GetById(1);
            return View(obj);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet]
        public IActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ContactUs(ContactUsViewModel model)
        {

            if (ModelState.IsValid)
            {
                var obj = new ContactUs
                {
                    id = model.id
       ,
                    name = model.name
       ,
                    Email  = model.Email
       ,
                    Mobileno = model.Mobileno
       ,
                    Address = model.Address
         
                };
 
               Int32 id= await _ContactUsServices.CreateAsync(obj);
                //var postId = await _CustomerRegistrationservices.CreateAsync(objcustomerRegistration);
                return RedirectToAction(nameof(Index));

            }
            else
            {
                return View();
            }

        }



        public IActionResult SubscribeDetails(Subscribe obj)
        {
            return View();
        }

        //private void AddDetails(EmpModel obj)
        //{
        //    connection();
        //    SqlCommand com = new SqlCommand("AddEmp", con);
        //    com.CommandType = CommandType.StoredProcedure;
        //    com.Parameters.AddWithValue("@Name", obj.Name);
        //    com.Parameters.AddWithValue("@City", obj.City);
        //    com.Parameters.AddWithValue("@Address", obj.Address);
        //    con.Open();
        //    com.ExecuteNonQuery();
        //    con.Close();

        //}


        public IActionResult BusinessListing(int productid)
        {
            BusinessListingViewModel obj = new BusinessListingViewModel();
            obj.objProductIndexViewModel = _productMasterServices.GetAll().Select(x => new ProductIndexViewModel
            {


                id = x.id,
                //sectorid = x.se,
                businessid = x.businessid,
                productName = x.productName,
                // BusinessRegistration = _BusinessRegistrationServiecess.GetById(x.businessid),
                // SectorRegistration = _SectorRegistrationServices.GetById(_BusinessRegistrationServiecess.GetById(x.businessid).sectorid),
                img = x.img

            }).ToList();
            var parameter = new DynamicParameters();
            parameter.Add("@productid", productid);
            obj.objgetBusinessAllInfo = _sP_Call.List<getBusinessAllInfo>("selectallBusinessDetailsAllInfo_byyProductId", parameter);


            //var parameter = new DynamicParameters();
            //parameter.Add("@productid", productid);
            ////IEnumerable<selectallBusinessDetailsDtos> obj = _sP_Call.List<selectallBusinessDetailsDtos>("selectallBusinessDetails", null);
            //obj.objgetBusinessAllInfo = _sP_Call.List<getBusinessAllInfo>("selectallBusinessDetailsAllInfo_byyProductId", parameter);

            return View(obj);
            //return View();
        }



        [HttpGet]
        public IActionResult Category()
        {
            var parameter = new DynamicParameters();            
            IEnumerable<selectallSectorWithBusinessCount> obj = _sP_Call.List<selectallSectorWithBusinessCount>("selectallSectorWithBusinessCount", null);
            
            return View(obj);
        }
        [HttpGet]
        public IActionResult Advertising()
        {
            return View();
        }


        public IActionResult TermsandConditions()
        {
            return View();
        }
        public IActionResult PrivacyPolicy()
        {
            return View();
        }

      
    }
}
