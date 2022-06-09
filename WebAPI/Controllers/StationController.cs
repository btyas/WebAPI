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
        
         [HttpGet]  // http://localhost:5000/api/Station/ListAvailibleStation
        public async Task<IActionResult> ListAvailibleStations()
        {
            var list_stations = await (_db.Stations.FromSqlRaw("Select * from dbo.Stations ").ToListAsync());
                                                                  



                return Ok(list_stations);
        }

        [HttpPost]    // http://localhost:5000/api/Station/SaveStation
       public async Task<IActionResult>  SaveStation(StationPos _station)
       {
                 var station = new StationPos
            {
                
                NameCity = _station.NameCity,
                StreetName = _station.StreetName,
                Status = _station.Status


        
            };
             _uow.StationRepository.AddStation(station);
             await _uow.SaveAsync();
             return  StatusCode(201);
       }

}