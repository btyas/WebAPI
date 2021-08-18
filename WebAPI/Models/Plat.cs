using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Plat
    {

        public int Id { get; set; }

        public int ImageId { get; set; }


        public ImagePlat imagePlat { get; set; }
    }
}
