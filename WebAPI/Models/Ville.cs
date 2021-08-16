using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Ville
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        
        [Key]

        public int VilleId { get; set; }


        
        public int CodePostal { get; set; }
        
        [StringLength(50)]
        public string NomVille { get; set; }

        [StringLength(3)]
        public string IdDepartment { get; set; }

        public List<User> ListofUsers { get; set; }

    }
}
