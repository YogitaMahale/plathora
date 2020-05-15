using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using plathora.Services;
using Microsoft.AspNetCore.Mvc;
using plathora.Models;
using plathora.Entity;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace plathora.Controllers
{
    public class AffiltateRegistrationController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IAffiltateRegistrationService _AffiltateRegistrationService;
        public AffiltateRegistrationController(IAffiltateRegistrationService AffiltateRegistrationService, IWebHostEnvironment hostingEnvironment)
        {
            _AffiltateRegistrationService = AffiltateRegistrationService;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            var affilatemaster = _AffiltateRegistrationService.GetAll().Select(x => new AffiltateRegistrationIndexViewModel
            {
                id = x.id,
                name = x.name,
                profilephoto = x.profilephoto,
                mobileno1 = x.mobileno1,
                mobileno2 = x.mobileno2,
                emailid1 = x.emailid1,
                DOB = x.DOB,
                createddate = x.createddate
            }).ToList();
            return View(affilatemaster);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var model = new AffiltateRegistrationCreateViewModel();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AffiltateRegistrationCreateViewModel model)
        {
            // id, name, profilephoto, mobileno1, mobileno2, emailid1, emailid2
            //, adharcardno, adharcardphoto, pancardno, pancardphoto, password
            //, gender, DOB, createddate
            if (ModelState.IsValid)
            {


                var objAffiltateRegistration = new AffiltateRegistration
                {
                    id = model.id,

                    name = model.name,
                    //profilephoto,
                    mobileno1 = model.mobileno1,
                    mobileno2 = model.mobileno2,
                    emailid1 = model.emailid1,
                    emailid2 = model.emailid2,
                    adharcardno = model.adharcardno,
                    //adharcardphoto,
                    pancardno = model.pancardno,
                    // pancardphoto,
                    password = model.password,
                    gender = model.gender,
                    DOB = model.DOB,
                    createddate = model.createddate
                };

                if (model.profilephoto != null && model.profilephoto.Length > 0)
                {
                    var uploadDir = @"uploads/Affiltate/profilephoto";
                    var fileName = Path.GetFileNameWithoutExtension(model.profilephoto.FileName);
                    var extesion = Path.GetExtension(model.profilephoto.FileName);
                    var webRootPath = _hostingEnvironment.WebRootPath;
                    fileName = DateTime.UtcNow.ToString("yymmssfff") + fileName + extesion;
                    var path = Path.Combine(webRootPath, uploadDir, fileName);
                    model.profilephoto.CopyToAsync(new FileStream(path, FileMode.Create));
                    objAffiltateRegistration.profilephoto = '/' + uploadDir + '/' + fileName;

                }
                if (model.pancardphoto != null && model.pancardphoto.Length > 0)
                {
                    var uploadDir = @"uploads/Affiltate/pancardphoto";
                    var fileName = Path.GetFileNameWithoutExtension(model.pancardphoto.FileName);
                    var extesion = Path.GetExtension(model.pancardphoto.FileName);
                    var webRootPath = _hostingEnvironment.WebRootPath;
                    fileName = DateTime.UtcNow.ToString("yymmssfff") + fileName + extesion;
                    var path = Path.Combine(webRootPath, uploadDir, fileName);
                    model.pancardphoto.CopyToAsync(new FileStream(path, FileMode.Create));
                    objAffiltateRegistration.pancardphoto = '/' + uploadDir + '/' + fileName;

                }
                if (model.adharcardphoto != null && model.adharcardphoto.Length > 0)
                {
                    var uploadDir = @"uploads/Affiltate/adharcardphoto";
                    var fileName = Path.GetFileNameWithoutExtension(model.adharcardphoto.FileName);
                    var extesion = Path.GetExtension(model.adharcardphoto.FileName);
                    var webRootPath = _hostingEnvironment.WebRootPath;
                    fileName = DateTime.UtcNow.ToString("yymmssfff") + fileName + extesion;
                    var path = Path.Combine(webRootPath, uploadDir, fileName);
                    model.adharcardphoto.CopyToAsync(new FileStream(path, FileMode.Create));
                    objAffiltateRegistration.adharcardphoto = '/' + uploadDir + '/' + fileName;

                }
                await _AffiltateRegistrationService.CreateAsync(objAffiltateRegistration);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var affilateregi = _AffiltateRegistrationService.GetById(id);
            if (affilateregi != null)
            {
                return NotFound();
            }
            var model = new AffiltateRegistrationEditViewModel
            {
                id = affilateregi.id,

                name = affilateregi.name,
                //   profilephoto = affilateregi.profilephoto,
                mobileno1 = affilateregi.mobileno1,
                mobileno2 = affilateregi.mobileno2,
                emailid1 = affilateregi.emailid1,
                emailid2 = affilateregi.emailid2,
                adharcardno = affilateregi.adharcardno,
                // adharcardphoto = affilateregi.adharcardno,
                pancardno = affilateregi.pancardno,
                //   pancardphoto = affilateregi.pancardno,
                password = affilateregi.password,
                gender = affilateregi.gender,
                DOB = affilateregi.DOB,
                createddate = affilateregi.createddate
            };
            return View(model);


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AffiltateRegistrationEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var affilatereg = _AffiltateRegistrationService.GetById(model.id);
                if (affilatereg == null)
                {
                    return NotFound();
                }
                affilatereg.id = model.id;
                affilatereg.name = model.name;
                //profilephoto,
                affilatereg.mobileno1 = model.mobileno1;
                affilatereg.mobileno2 = model.mobileno2;
                affilatereg.emailid1 = model.emailid1;
                affilatereg.emailid2 = model.emailid2;
                affilatereg.adharcardno = model.adharcardno;
                //adharcardphoto,
                affilatereg.pancardno = model.pancardno;
                // pancardphoto,
                affilatereg.password = model.password;
                affilatereg.gender = model.gender;
                affilatereg.DOB = model.DOB;
                affilatereg.createddate = model.createddate;
                if (model.profilephoto != null && model.profilephoto.Length > 0)
                {
                    var uploadDir = @"uploads/Affiltate/profilephoto";
                    var fileName = Path.GetFileNameWithoutExtension(model.profilephoto.FileName);
                    var extesion = Path.GetExtension(model.profilephoto.FileName);
                    var webRootPath = _hostingEnvironment.WebRootPath;
                    fileName = DateTime.UtcNow.ToString("yymmssfff") + fileName + extesion;
                    var path = Path.Combine(webRootPath, uploadDir, fileName);
                    model.profilephoto.CopyToAsync(new FileStream(path, FileMode.Create));
                    affilatereg.profilephoto = '/' + uploadDir + '/' + fileName;

                }
                if (model.pancardphoto != null && model.pancardphoto.Length > 0)
                {
                    var uploadDir = @"uploads/Affiltate/pancardphoto";
                    var fileName = Path.GetFileNameWithoutExtension(model.pancardphoto.FileName);
                    var extesion = Path.GetExtension(model.pancardphoto.FileName);
                    var webRootPath = _hostingEnvironment.WebRootPath;
                    fileName = DateTime.UtcNow.ToString("yymmssfff") + fileName + extesion;
                    var path = Path.Combine(webRootPath, uploadDir, fileName);
                    model.pancardphoto.CopyToAsync(new FileStream(path, FileMode.Create));
                    affilatereg.pancardphoto = '/' + uploadDir + '/' + fileName;

                }
                if (model.adharcardphoto != null && model.adharcardphoto.Length > 0)
                {
                    var uploadDir = @"uploads/Affiltate/adharcardphoto";
                    var fileName = Path.GetFileNameWithoutExtension(model.adharcardphoto.FileName);
                    var extesion = Path.GetExtension(model.adharcardphoto.FileName);
                    var webRootPath = _hostingEnvironment.WebRootPath;
                    fileName = DateTime.UtcNow.ToString("yymmssfff") + fileName + extesion;
                    var path = Path.Combine(webRootPath, uploadDir, fileName);
                    model.adharcardphoto.CopyToAsync(new FileStream(path, FileMode.Create));
                    affilatereg.adharcardphoto = '/' + uploadDir + '/' + fileName;

                }
                await _AffiltateRegistrationService.UpdateAsync(affilatereg);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var model = _AffiltateRegistrationService.GetById(id);
            if (model == null)
            {
                return NotFound();
            }
            AffiltateRegistrationDetailsViewModel obj = new AffiltateRegistrationDetailsViewModel()
            {
                id = model.id,
                name = model.name,
                profilephoto = model.profilephoto,
                mobileno1 = model.mobileno1,
                mobileno2 = model.mobileno2,
                emailid1 = model.emailid1,
                emailid2 = model.emailid2,
                adharcardno = model.adharcardno,
                adharcardphoto = model.adharcardphoto,
                pancardno = model.pancardno,
                pancardphoto = model.pancardphoto,
                password = model.password,
                gender = model.gender,
                DOB = model.DOB,
                createddate = model.createddate

            };
            return View(obj);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var emp = _AffiltateRegistrationService.GetById(id);
            if (emp == null)
            {
                return NotFound();

            }
            AffiltateRegistrationDeleteViewModel model = new AffiltateRegistrationDeleteViewModel()
            {
                id = emp.id,
                name  = emp.name 
            };


            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(AffiltateRegistrationDeleteViewModel model)
        {
            await _AffiltateRegistrationService.Delete(model.id);
            return RedirectToAction(nameof(Index));
        }
    }
}
