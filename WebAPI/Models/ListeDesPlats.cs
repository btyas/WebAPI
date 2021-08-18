using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class ListeDesPlats
    {

        public int Id { get; set; }

        public int NombrePlats { get; set; }

        

        public ICollection<Plat> plats { get; set; }


    }
}
