using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class ImagePlat
    {



        public int Id { get; set; }

        
        public string ImageplatName { get; set; }

        public int PlatId { get; set; }
        public  Plat plat { get; set; }
    }
}
