﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
            

            public DbSet<User>  Users { get; set; }
            public DbSet<City> Cities {get; set;}
            public DbSet<StationPos> Stations {get; set;}
            public DbSet<Street> Streets {get; set;}
    }
}
    

