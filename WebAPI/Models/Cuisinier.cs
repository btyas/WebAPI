using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Cuisinier
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string ImageCuisinierUrl { get; set; }

        
          
        [Required]
        [MaxLength(50)]
        public string Name { get;  set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        public string email { get; set; }

        public string Adresse { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        
        public int ZIPCode { get; set; }

        public int Gender { get; set; }  // 0 Male, 1 : Female

        [ForeignKey("CityFKId")]
        public int CityId { get; set; }
    }

   
}
