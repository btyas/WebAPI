﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Interfaces;

namespace WebAPI.Data.Repo
{
    public class UnitOfWork : IUnitofwork
    {
        private readonly DataContext dc;

        public UnitOfWork(DataContext dc)
        {
            this.dc = dc;
        }
        
        public ICityRepository CityRepository => 
            new CityRepository(dc);

        public ICuisinerRepository CuisinierRepository => 
             new CuisinierRepository(dc);

        public IUserRepository UserRepository =>
            new UserRepository(dc);
      

        public async Task<bool> SaveAsync()
        {
            return await dc.SaveChangesAsync() > 0;
        }

       
    }
}
