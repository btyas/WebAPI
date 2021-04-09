using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Cuisiniers
    {
        public int Id { get; set; }
        public string ImageCuisinierUrl { get; set; }

        public List<ImageUrl> ImageUrls { get; set;  }
    }

   
}
