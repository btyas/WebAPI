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
            public DbSet<City> Cities { get; set; }

            public DbSet<Cuisinier> Cuisiniers { get; set; }

            public DbSet<Ville>  Villes { get; set; }

            public DbSet<User>  Users { get; set; }
    }
}
    

