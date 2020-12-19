﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
 
using plathora.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
//using plathora.DataAccess;
//using plathora.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Microsoft.AspNetCore.Authorization;
using plathora.Utility;
using plathora.Persistence;
using Microsoft.AspNetCore.Authorization;

using plathora.Utility;
using Microsoft.AspNetCore.Identity;
using plathora.Entity;
using plathora.Services;
using plathora.Services.Implementation;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace CoreMoryatools.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    
    //[Authorize(Roles = SD.Role_Admin + "," + SD.Role_Employee)]
    public class UserController : Controller
    {
       private readonly IWebHostEnvironment _hostingEnvironment;
      //  private readonly IAffiltateRegistrationService _AffiltateRegistrationService;
        private readonly IMembershipServices _MembershipServices;
        private readonly ICountryRegistrationservices _CountryRegistrationservices;
        private readonly IStateRegistrationService _StateRegistrationService;
        private readonly ICityRegistrationservices _CityRegistrationservices;
        private readonly IAffilatePackageServices _AffilatePackageServices;
        private readonly UserManager<IdentityUser> _userManager;

        private readonly ApplicationDbContext _db;
        //private readonly UserManager<ApplicationUser> _usermanager;
        public UserController(ApplicationDbContext db, IMembershipServices MembershipServices, ICountryRegistrationservices CountryRegistrationservices, ICityRegistrationservices CityRegistrationservices, IAffilatePackageServices AffilatePackageServices, IStateRegistrationService StateRegistrationService, IWebHostEnvironment hostingEnvironment, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _MembershipServices = MembershipServices;
            _CountryRegistrationservices = CountryRegistrationservices;
            _StateRegistrationService = StateRegistrationService; ;
            _CityRegistrationservices = CityRegistrationservices;
            _AffilatePackageServices = AffilatePackageServices;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
            //_usermanager = usermanager;
        }
        public IActionResult Index()
        {
            return View();
        }

 //       [HttpGet]
 //       public IActionResult Edit(string id)
 //       {
 //           var objfromdb = _db.applicationUsers.FirstOrDefault(u => u.Id == id);
 //           ViewBag.Countries = _CountryRegistrationservices.GetAllCountry();
 //           ViewBag.membershiplist = _MembershipServices.GetAll().ToList();
 //           int countryiddd = 0, stateid=0, countryid=0;


 //           //get role name
 //           var userRole = _db.UserRoles.ToList();
 //           var Roles = _db.Roles.ToList();
 //           var roleId = userRole.FirstOrDefault(u => u.UserId == id).RoleId;
 //          string rolname = Roles.FirstOrDefault(u => u.Id == roleId).Name;



 //           if (objfromdb.cityid!=null)
 //           {
 //               countryiddd =(int) objfromdb.cityid;
 //                 stateid = _CityRegistrationservices.GetById(countryiddd).stateid;
 //                 countryid = _StateRegistrationService.GetById(stateid).countryid;
 //           }
          
 //           if (objfromdb == null)
 //           {
 //               return NotFound();
 //           }
 //           var model = new EditApplicationUser
 //           {
 //               Id=objfromdb.Id,
 //              name= objfromdb.name ,
 ////profilephoto = objfromdb.name
 //PhoneNumber = objfromdb.PhoneNumber,
 //mobileno2 = objfromdb.mobileno2,
 //Email = objfromdb.Email,
 //emailid2 = objfromdb.emailid2,
 //adharcardno = objfromdb.adharcardno,
 ////adharcardphoto = objfromdb.adharcardphoto,
 //pancardno = objfromdb.pancardno,
 ////pancardphoto = objfromdb.pancardphoto,
 //gender = objfromdb.gender,
 //DOB = objfromdb.DOB,
 //house = objfromdb.house,
 //landmark = objfromdb.landmark,
 //street = objfromdb.street,
 //countryid = countryiddd,
 //stateid =stateid,
 // cityid = objfromdb.cityid ,
 //zipcode = objfromdb.zipcode,
 //latitude = objfromdb.latitude,
 //longitude = objfromdb.longitude,
 //companyName = objfromdb.companyName,
 //designation = objfromdb.designation,
 //gstno = objfromdb.gstno,
 //Website = objfromdb.Website ,
 //bankname = objfromdb.bankname,
 //accountname = objfromdb.accountname,
 //accountno = objfromdb.accountno,
 //ifsccode = objfromdb.ifsccode,
 //branch = objfromdb.branch,
 ////passbookphoto = objfromdb.passbookphoto,
 // Membershipid = objfromdb.Membershipid,
 //amount = objfromdb.amount,
 //rolename=rolname
 
 //           };
 //           ViewBag.States = _StateRegistrationService.GetAllState(countryid);
 //           ViewBag.Cities = _CityRegistrationservices.GetAllCity(stateid);
 //           return View(model);

 //       }

 //       [HttpPost]
 //       [ValidateAntiForgeryToken]
 //       public async Task<IActionResult> Edit(EditApplicationUser model)
 //       {
 //           if (ModelState.IsValid)
 //           {
                 
 //               var affilatereg = _db.applicationUsers.FirstOrDefault(u => u.Id ==model.Id);
 //               if (affilatereg == null)
 //               {
 //                   return NotFound();
 //               }



 //               affilatereg.Id = model.Id;
 //               affilatereg.name = model.name;
 //               //profilephoto,
 //               affilatereg.PhoneNumber  = model.PhoneNumber ;
 //               affilatereg.mobileno2 = model.mobileno2;
 //               affilatereg.Email = model.Email;
 //               affilatereg.emailid2 = model.emailid2;
 //               affilatereg.adharcardno = model.adharcardno;
 //               //adharcardphoto,
 //               affilatereg.pancardno = model.pancardno;
 //               // pancardphoto,
             
 //               affilatereg.gender = model.gender;
 //               affilatereg.DOB = model.DOB;
 //               //   affilatereg.createddate = model.createddate;
 //               affilatereg.house = model.house;
 //               affilatereg.landmark = model.landmark;
 //               affilatereg.street = model.street;
 //               affilatereg.cityid = model.cityid;
 //               affilatereg.companyName = model.companyName;
 //               affilatereg.designation = model.designation;
 //               affilatereg.gstno = model.gstno;
 //               affilatereg.Website = model.Website;
 //               affilatereg.bankname = model.bankname;
 //               affilatereg.accountname = model.accountname;

 //               affilatereg.accountno = model.accountno;
 //               affilatereg.ifsccode = model.ifsccode;
 //               affilatereg.branch = model.branch;
 //               affilatereg.Membershipid = model.Membershipid;
 //               affilatereg.amount = model.amount;
               

 //               if (model.profilephoto != null && model.profilephoto.Length > 0)
 //               {
 //                   var uploadDir = @"uploads/user/profilephoto";
 //                   var fileName = Path.GetFileNameWithoutExtension(model.profilephoto.FileName);
 //                   var extesion = Path.GetExtension(model.profilephoto.FileName);
 //                   var webRootPath = _hostingEnvironment.WebRootPath;
 //                   fileName = DateTime.UtcNow.ToString("yymmssfff") + fileName + extesion;
 //                   var path = Path.Combine(webRootPath, uploadDir, fileName);
 //                   await model.profilephoto.CopyToAsync(new FileStream(path, FileMode.Create));
 //                   affilatereg.profilephoto = '/' + uploadDir + '/' + fileName;

 //               }
 //               if (model.pancardphoto != null && model.pancardphoto.Length > 0)
 //               {
 //                   var uploadDir = @"uploads/user/pancardphoto";
 //                   var fileName = Path.GetFileNameWithoutExtension(model.pancardphoto.FileName);
 //                   var extesion = Path.GetExtension(model.pancardphoto.FileName);
 //                   var webRootPath = _hostingEnvironment.WebRootPath;
 //                   fileName = DateTime.UtcNow.ToString("yymmssfff") + fileName + extesion;
 //                   var path = Path.Combine(webRootPath, uploadDir, fileName);
 //                   await model.pancardphoto.CopyToAsync(new FileStream(path, FileMode.Create));
 //                   affilatereg.pancardphoto = '/' + uploadDir + '/' + fileName;

 //               }
 //               if (model.adharcardphoto != null && model.adharcardphoto.Length > 0)
 //               {
 //                   var uploadDir = @"uploads/user/adharcardphoto";
 //                   var fileName = Path.GetFileNameWithoutExtension(model.adharcardphoto.FileName);
 //                   var extesion = Path.GetExtension(model.adharcardphoto.FileName);
 //                   var webRootPath = _hostingEnvironment.WebRootPath;
 //                   fileName = DateTime.UtcNow.ToString("yymmssfff") + fileName + extesion;
 //                   var path = Path.Combine(webRootPath, uploadDir, fileName);
 //                   await model.adharcardphoto.CopyToAsync(new FileStream(path, FileMode.Create));
 //                   affilatereg.adharcardphoto = '/' + uploadDir + '/' + fileName;

 //               }
 //               if (model.passbookphoto != null && model.passbookphoto.Length > 0)
 //               {
 //                   var uploadDir = @"uploads/user/passbookphoto";
 //                   var fileName = Path.GetFileNameWithoutExtension(model.passbookphoto.FileName);
 //                   var extesion = Path.GetExtension(model.passbookphoto.FileName);
 //                   var webRootPath = _hostingEnvironment.WebRootPath;
 //                   fileName = DateTime.UtcNow.ToString("yymmssfff") + fileName + extesion;
 //                   var path = Path.Combine(webRootPath, uploadDir, fileName);
 //                   await model.passbookphoto.CopyToAsync(new FileStream(path, FileMode.Create));
 //                   affilatereg.passbookphoto = '/' + uploadDir + '/' + fileName;

 //               }
 //               var result = await _userManager.UpdateAsync(affilatereg);
 //              // await _AffiltateRegistrationService.UpdateAsync(affilatereg);
 //               return RedirectToAction(nameof(Index));
 //           }
 //           else
 //           {
 //               return View();
 //           }

 //       }

        #region "API CALL"
        [HttpGet]
        public IActionResult GetALL()
        {

            //var userList = _db.ApplicationUser.Include(u => u.company).ToList();
            var userList = _db.applicationUsers.ToList();
            var userRole = _db.UserRoles.ToList();
            var Roles = _db.Roles.ToList();
            foreach(var user in userList)
            {
                var roleId = userRole.FirstOrDefault(u => u.UserId == user.Id).RoleId;
                user.Role = Roles.FirstOrDefault(u => u.Id == roleId).Name;
                //if(user.company==null)
                //{
                //    user.company = new company()
                //    {
                //        Name = ""
                //    };
                //}

            }
            return Json(new { data = userList });
            //var obj = _unitofWork.category.GetAll();
            //return Json(new { data = obj });
        }

      



        [HttpPost]
       public IActionResult Lockunlock([FromBody] string id)
        {
            var objfromdb = _db.applicationUsers.FirstOrDefault(u => u.Id == id);
            if(objfromdb==null)
            {
                return Json(new { success = false, message = "error while locking / unlocking" });
            }
            if(objfromdb.LockoutEnd!=null&&objfromdb.LockoutEnd>DateTime.Now)
            {
                objfromdb.LockoutEnd = DateTime.Now;
            }
            else
            {
                objfromdb.LockoutEnd = DateTime.Now.AddYears(1000);
            }
            _db.SaveChanges();
            return Json(new { success = true , message = "Operation successful" });
        }

        //public ApplicationUser ApUser { get; set; }
        [HttpDelete]
        public async Task<ActionResult> Delete(string id)
        {


            var objfromdb = _db.applicationUsers.FirstOrDefault(u => u.Id == id);
            if (objfromdb != null)
            {

                IdentityResult result = await _userManager.DeleteAsync(objfromdb);
                return Json(new { success = true, message = "Delete Successfuly" });
            }
            else
            {
                return Json(new { success = false, message = "Error while deleteing" });
            }


        }
        #endregion
    }
}