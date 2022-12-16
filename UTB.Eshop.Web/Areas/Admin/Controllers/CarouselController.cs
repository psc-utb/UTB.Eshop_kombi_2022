using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UTB.Eshop.Application.Abstraction;
using UTB.Eshop.Domain.Entities;
using UTB.Eshop.Infrastructure.Database;
using UTB.Eshop.Web.Controllers;

namespace UTB.Eshop.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CarouselController : Controller
    {
        ICarouselAppService _carouselAppService;
        public CarouselController(ICarouselAppService carouselAppService)
        {
            _carouselAppService = carouselAppService;
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
                _carouselAppService.CreateCarouselItem(carouselItem);

                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", String.Empty), new { area = String.Empty });
                //return RedirectToAction("Index", "Home", new { area = "" });
            }

            return View(carouselItem);
        }

    }
}
