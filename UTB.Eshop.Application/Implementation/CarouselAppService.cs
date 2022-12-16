using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.Eshop.Application.Abstraction;
using UTB.Eshop.Domain.Entities;
using UTB.Eshop.Infrastructure.Database;

namespace UTB.Eshop.Application.Implementation
{
    public class CarouselAppService : ICarouselAppService
    {
        readonly EshopDbContext _eshopDbContext;
        public CarouselAppService(EshopDbContext eshopDbContext)
        {
            _eshopDbContext = eshopDbContext;
        }

        public void CreateCarouselItem(CarouselItem carouselItem)
        {
            _eshopDbContext.Add(carouselItem);
            _eshopDbContext.SaveChanges();
        }
    }
}
