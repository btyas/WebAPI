using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
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

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CuisinierController : ControllerBase
    {

        private readonly IUnitofwork uow;
        private readonly DataContext _db;


        public CuisinierController(IUnitofwork uow, DataContext _db)
        {
            this.uow = uow;
            this._db = _db;
             
        }

        // Get api/Cuisinier/ListCuisiniers
        [HttpGet]
        public async Task<IActionResult> ListCuisiniers()
        {

            var list_cuisinier =  await (from cuisinier in _db.Cuisiniers
                                 select cuisinier).ToListAsync();

            //var list_cuisinier = await (from cuisinier in _db.Cuisiniers
            //                            join citie in _db.Cities
            //                            on cuisinier.Id equals citie.Id
            //                            select new CuisinierInfo
            //                            {
            //                                CuisinierName = cuisinier.Name,
            //                                CityCuisinier =citie.Name,
            //                                CuisinierId = cuisinier.Id




            //                            }).ToListAsync();
                                               
            
         //   var cuisinier = await uow.CuisinierRepository.GetCuisiniersAsync();
          

            return Ok(list_cuisinier);
        }
        // Post api/city/add?citynaame

        [HttpPatch("update/{id}")]

        public async Task<IActionResult> UpdateCuisinier(int id )
        {

            var CuisinierFromDb = await uow.CuisinierRepository.FindCuisinier(id);

             
            await uow.SaveAsync();
            return StatusCode(200);
        }


        [HttpPut("update/{id}")]

        public async Task<IActionResult> UpdateCuisinier(int id, Cuisinier _cuisinierUpdate)
        {

            var CuisinierFromDb = await uow.CityRepository.FindCity(id);
            

          
            await uow.SaveAsync();
            return StatusCode(200);
        }


        [HttpPost]   //api/Cuisinier/AddCuisinier
        public async  Task<IActionResult>  AddCuisinier (Cuisinier  CuisinierName)
        {
            var cuisinier = new Cuisinier
            {
                Name = CuisinierName.Name,
                Adresse = CuisinierName.Adresse,
                LastName = CuisinierName.LastName,
                Phone = CuisinierName.Phone,
                email = CuisinierName.email,
                ZIPCode = CuisinierName.ZIPCode,
                Gender = CuisinierName.Gender,
                CityId = CuisinierName.ZIPCode




            };

              if (cuisinier.CityId == 92220)
            {
                cuisinier.CityId = 1;
            }
            uow.CuisinierRepository.AddCuisinier(cuisinier);
            await uow.SaveAsync();
            return StatusCode(201);

        }

        // Post api/city/add?cityname=Miami
        // Post api/city/add/Los Angeles
        //[HttpPost("add")]
        //[HttpPost("add/{cityName}")]

        //public async Task<IActionResult> AddCity(string cityName)
        //{
        //    City city = new City();
        //    city.Name = cityName;
        //    await uow.CityRepository.AddCity(city);
        //    return Ok(city);
        //}

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Deletecuisiner(int id)
        {
            uow.CuisinierRepository.DeleteCuisinier(id);

            await uow.SaveAsync();

            return Ok(id);

        }



    }
}
