using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.Eshop.Domain.Entities;

namespace UTB.Eshop.Infrastructure.Database
{
    public class EshopDbContext : DbContext
    {
        public DbSet<CarouselItem> CarouselItems { get; set; }

        public EshopDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            DatabaseInit databaseInit = new DatabaseInit();
            builder.Entity<CarouselItem>().HasData(databaseInit.CreateCarouselItems());
        }
    }
}
