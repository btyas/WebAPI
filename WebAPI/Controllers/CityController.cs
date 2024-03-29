﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
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
        private readonly IMapper mapper;

        public CityController(IUnitofwork uow, IMapper mapper)
        {

            this.uow = uow;
            this.mapper = mapper;
        }

        // Get api/City
        [HttpGet]
        public async Task<IActionResult> GetCities()
        {
            var cities = await uow.CityRepository.GetCitiesAsync();
            var citiesDto = mapper.Map<IEnumerable<CityDto>>(cities);
            
            return Ok(citiesDto);
        }
        // Post api/city/add?citynaame

        [HttpPatch("update/{id}")]

        public async Task<IActionResult> UpdateCity(int id, JsonPatchDocument<City> cityToPat)
        {

            var cityFromDb = await uow.CityRepository.FindCity(id);
            

            cityToPat.ApplyTo(cityFromDb, ModelState);
            await uow.SaveAsync();
            return StatusCode(200);
        }






        [HttpPut("update/{id}")]

        public async Task<IActionResult> UpdateCity(int id, CityDto cityDto)
        {

            var cityFromDb = await uow.CityRepository.FindCity(id);
           

            mapper.Map(cityDto, cityFromDb);
            await uow.SaveAsync();
            return StatusCode(200);
        }


        [HttpPost("post")] 
        public async Task<IActionResult> AddCity(CityDto cityDto)
        {
            var city = new City
            {
                Name = cityDto.Name,
                

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
