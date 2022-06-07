using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models {
    
    public class StaionPos
    {
        public int Id { get; set; }

        public string NameCity  { get; set; }

        
        public string AdressPostal { get; set; }
        
        public  Street street  { get; set; }

    }

}