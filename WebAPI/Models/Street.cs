using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace WebAPI.Models {

public  class Street 
{
  public int Id { get; set; }

  public IList<StaionPos> stations { get; set; }

  public City City { get; set; }
}
}