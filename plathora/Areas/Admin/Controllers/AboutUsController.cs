//using appFoodDelivery.Entity;
//using appFoodDelivery.Models;
using appFoodDelivery.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using plathora.Entity;
using plathora.Services;
using plathora.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appFoodDelivery.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]

    // [Authorize(Roles = SD.Role_Admin)]
    public class AboutUsController : Controller
    {

        private readonly IAboutUsServices _AboutUsServices;
        public AboutUsController(IAboutUsServices AboutUsServices)
        {
            _AboutUsServices =AboutUsServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Edit()
        {
            var storeowner = _AboutUsServices.GetById(1);
            if (storeowner == null)
            {
                return NotFound();
            }
            var model = new AboutUs()
            {
                id = storeowner.id,
                AboutUsText = storeowner.AboutUsText


            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AboutUs model)
        {
            if (ModelState.IsValid)
            {
                var storeobj = _AboutUsServices.GetById(model.id);
                if (storeobj == null)
                {
                    TempData["error"] = "Record Not Found";
                    return NotFound();
                }
                storeobj.id = model.id;
                storeobj.AboutUsText = model.AboutUsText ;
                
                await _AboutUsServices.UpdateAsync(storeobj);
                TempData["success"] = "Record Update successfully";
                return RedirectToAction(nameof(Edit));
            }
            else
            {
                return View();
            }

        }

    }
}
