﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data.Repo;

namespace WebAPI.Interfaces
{
   public  interface IUnitofwork
    {
        
        IUserRepository UserRepository { get; }

        
        Task<bool> SaveAsync();
        
    }
}
