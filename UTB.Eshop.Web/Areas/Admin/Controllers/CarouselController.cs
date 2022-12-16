using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UTB.Eshop.Domain.Entities;
using UTB.Eshop.Infrastructure.Database;
using UTB.Eshop.Web.Controllers;

namespace UTB.Eshop.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CarouselController : Controller
    {
        readonly EshopDbContext _eshopDbContext;
        public CarouselController(EshopDbContext eshopDbContext)
        {
            _eshopDbContext = eshopDbContext;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CarouselItem carouselItem)
        {
            if (ModelState.IsValid)
            {
                _eshopDbContext.Add(carouselItem);
                _eshopDbContext.SaveChanges();

                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", String.Empty), new { area = String.Empty });
                //return RedirectToAction("Index", "Home", new { area = "" });
            }

            return View(carouselItem);
        }

    }
}
