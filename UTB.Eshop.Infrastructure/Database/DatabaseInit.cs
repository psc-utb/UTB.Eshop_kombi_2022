using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.Eshop.Domain.Entities;

namespace UTB.Eshop.Infrastructure.Database
{
    class DatabaseInit
    {
        public List<CarouselItem> CreateCarouselItems()
        {
            List<CarouselItem> carouselItems =
                new List<CarouselItem>();

            CarouselItem ci1 = new CarouselItem()
            {
                ID = 1,
                ImageSrc = "/img/carousel/how-to-become-an-information-technology-specialist160684886950141.jpg",
                ImageAlt = "First slide"
            };


            CarouselItem ci2 = new CarouselItem()
            {
                ID = 2,
                ImageSrc = "/img/carousel/Information-Technology-1-1024x462.jpg",
                ImageAlt = "Second slide"
            };


            CarouselItem ci3 = new CarouselItem()
            {
                ID = 3,
                ImageSrc = "/img/carousel/Information-Technology.jpg",
                ImageAlt = "Third slide"
            };

            carouselItems.Add(ci1);
            carouselItems.Add(ci2);
            carouselItems.Add(ci3);

            return carouselItems;
        }
    }
}
