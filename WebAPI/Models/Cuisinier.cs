using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Cuisinier
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string ImageCuisinierUrl { get; set; }

        public List<ImageUrl> ImageUrlId { get; set;  }
          
        [Required]
        [MaxLength(50)]
        public string Name { get;  set; }
    }

   
}
