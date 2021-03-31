using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.Data.Repo;
using WebAPI.Dtos;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {

        private readonly IUnitofwork uow;


        public CityController(IUnitofwork uow)
        {

            this.uow = uow;
        }

        // Get api/City
        [HttpGet]
        public async Task<IActionResult> GetCities()
        {
            var cities = await uow.CityRepository.GetCitiesAsync();
            return Ok(cities);
        }
        // Post api/city/add?citynaame



        [HttpPost("post")] 
        public async Task<IActionResult> AddCity(CityDto cityDto)
        {
            var city = new City
            {
                Name = cityDto.Name,
                LastUpdatedBy = 1,
                LastUpdatedOn = DateTime.Now

            };
            uow.CityRepository.AddCity(city);
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
        public async Task<IActionResult> DeleteCity(int id)
        {
            uow.CityRepository.DeleteCity(id);

            await uow.SaveAsync();

            return Ok(id);
            
        }
    }
}
