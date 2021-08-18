using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Country { get; set; }
        

        public List<Cuisinier> ListofCuisiniers { get; set; }

        [ForeignKey("City-Cuisinier-FK")]
        public int CuisinierID { get; set; }

        public ICollection<User> ListOFUsers { get; set; }

        [ForeignKey("City-Users-FK")]
        public int UserId { get; set; }
    }
}
