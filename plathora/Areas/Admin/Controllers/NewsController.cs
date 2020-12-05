using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using plathora.Entity;
using plathora.Models;
using plathora.Services;

using Microsoft.AspNetCore.Authorization;

using plathora.Utility;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace plathora.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class NewsController : Controller
    {
        private readonly INewsServices _newsServices;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public NewsController(INewsServices newsServices, IWebHostEnvironment hostingEnvironment)
        {
            _newsServices = newsServices;
            _hostingEnvironment = hostingEnvironment;

        }

        public IActionResult Index()
        {
            var countrydetails = _newsServices.GetAll().Select(x => new NewIndexViewModel
            {
                id = x.id,
                title=x.title,
                img=x.img,
                description=x.description,
                isdeleted = x.isdeleted,
                isactive=x.isactive,
                date1=x.date1,
                createddate=x.createddate

            }).ToList();
            return View(countrydetails);


        }
        [HttpGet]
        public IActionResult Create()
        {
            var model = new NewCreateViewModel();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NewCreateViewModel model)
        {

            if (ModelState.IsValid)
            {
                var objcountry = new News
                {
                    id = model.id,
                    title = model.title,
                     description=model.description,
                    isdeleted = false,
                    isactive = false,
                    date1=model.date1,
                    createddate=model.createddate

                };
                if (model.img  != null && model.img.Length > 0)
                {
                    var uploadDir = @"uploads/News";
                    var fileName = Path.GetFileNameWithoutExtension(model.img.FileName);
                    var extesion = Path.GetExtension(model.img.FileName);
                    var webRootPath = _hostingEnvironment.WebRootPath;
                    fileName = DateTime.UtcNow.ToString("yymmssfff") + fileName + extesion;
                    var path = Path.Combine(webRootPath, uploadDir, fileName);
                    await model.img.CopyToAsync(new FileStream(path, FileMode.Create));
                    objcountry.img = '/' + uploadDir + '/' + fileName;

                }
                
                await _newsServices.CreateAsync(objcountry);
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
            var objcountry = _newsServices.GetById(id);
            if (objcountry == null)
            {
                return NotFound();
            }
            var model = new NewCreateViewModel
            {
                id = objcountry.id,
                title = objcountry.title,
                description=objcountry.description,
                date1=objcountry.date1

            };
            return View(model);


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(NewCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var objcountry = _newsServices.GetById(model.id);
                if (objcountry == null)
                {
                    return NotFound();
                }
                objcountry.id = model.id;
                objcountry.title = model.title;
                objcountry.description = model.description;
                objcountry.date1 = model.date1;
                if (model.img != null && model.img.Length > 0)
                {
                    var uploadDir = @"uploads/News";
                    var fileName = Path.GetFileNameWithoutExtension(model.img.FileName);
                    var extesion = Path.GetExtension(model.img.FileName);
                    var webRootPath = _hostingEnvironment.WebRootPath;
                    fileName = DateTime.UtcNow.ToString("yymmssfff") + fileName + extesion;
                    var path = Path.Combine(webRootPath, uploadDir, fileName);
                    await model.img.CopyToAsync(new FileStream(path, FileMode.Create));
                    objcountry.img = '/' + uploadDir + '/' + fileName;

                }
               
                await _newsServices.UpdateAsync(objcountry);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }

        }


        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await _newsServices.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
