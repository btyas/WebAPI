using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.Dtos;
using WebAPI.Interfaces;
using WebAPI.Models;


[Route("api/[controller]/[action]")]
[ApiController]

public class StationController : ControllerBase {

        private readonly IUnitofwork _uow;
        private readonly DataContext _db;


        public StationController (IUnitofwork uow, DataContext db)
         {      
              this._uow = uow;
              this._db =  db;

         }
        
         [HttpGet]
        public async Task<IActionResult> ListAvailibleStations()
        {
            var list_stations = await (_db.Stations.FromSqlRaw("Select * from dbo.Stations ").ToListAsync());
                                                                  



                return Ok(list_stations);
        }
}