using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models {
    public class City
    {
        public int Id { get; set; }

        public string NameCity  { get; set; }

        [ForeignKey("AdrPostal")]

        public string AdressPostal { get; set; }
        
        public  IList<Street> streets  { get; set; }

    }

}