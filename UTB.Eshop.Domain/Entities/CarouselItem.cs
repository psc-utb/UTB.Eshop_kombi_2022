using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.Eshop.Domain.Validation;

namespace UTB.Eshop.Domain.Entities
{
    [Table("CarouselItem")]
    public class CarouselItem
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string ImageSrc { get; set; }

        [LowerCases]
        public string ImageAlt { get; set; }
    }
}
