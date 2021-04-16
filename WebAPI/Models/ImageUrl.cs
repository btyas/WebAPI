﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class ImageUrl
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string ImagePaths { get; set; }

        
    }
}
