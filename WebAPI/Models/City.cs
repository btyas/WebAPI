using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class City
    {
       
        public string Name { get; set; }

        public string Country { get; set; }

         [Key]
         [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodePostale { get; set; }
     


        public ICollection<User> ListOFUsers { get; set; }

        [ForeignKey("City-Users-FK")]
        public int UserId { get; set; }
    }
}
