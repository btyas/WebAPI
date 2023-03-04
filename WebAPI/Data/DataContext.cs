using Microsoft.EntityFrameworkCore;
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

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             {
        optionsBuilder.UseOracle("connection_string");
              }

            public DbSet<City> Cities { get; set; }

        
 
        




            public DbSet<User>  Users { get; set; }
    }



}
    

