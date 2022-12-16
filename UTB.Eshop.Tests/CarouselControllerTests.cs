using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Linq;
using UTB.Eshop.Application.Abstraction;
using UTB.Eshop.Domain.Entities;
using UTB.Eshop.Web.Areas.Admin.Controllers;
using Xunit;

namespace UTB.Eshop.Tests
{
    public class CarouselControllerTests
    {
        [Fact]
        public void Test1()
        {
            //arrange - priprava
            Mock<ICarouselAppService> mockCarousel = new Mock<ICarouselAppService>();
            mockCarousel.Setup(carouselAppService => carouselAppService.CreateCarouselItem(It.IsAny<CarouselItem>())).Callback(() => { return; });

            CarouselController carouselController = new CarouselController(mockCarousel.Object);
            CarouselItem carouselItem = new CarouselItem()
            {
                ID = 0,
                ImageSrc = "a",
                ImageAlt = ""
            };

            //carouselController.ModelState.AddModelError("ImageSource", "sadsad");

            //act - akce
            IActionResult actionResult = carouselController.Create(carouselItem);


            //assert - vyhodnoceni
            RedirectToActionResult redirectResult = Assert.IsType<RedirectToActionResult>(actionResult);
            Assert.Matches(redirectResult.ActionName, "Index");
            Assert.Matches(redirectResult.ControllerName, "Home");
            Assert.Matches(redirectResult.RouteValues.Single(keyValuePair => keyValuePair.Key == "area").Value.ToString(), String.Empty);

        }
    }
}
