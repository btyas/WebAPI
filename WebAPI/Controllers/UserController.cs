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

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitofwork uow;
        private readonly DataContext _db;


        public UserController(IUnitofwork uow, DataContext _db)
        {
            this.uow = uow;
            this._db = _db;
        }
        // GET: api/User/ListUsers
        [HttpGet]
        public async  Task<IActionResult> ListUsers()
        {

            var list_users = await (from user in _db.Users 

                                    select user).ToListAsync();

            return Ok(list_users);




            
        }
        
        // GET api/<VilleController>/5
        [HttpGet]
        public async Task<IActionResult> ListUsersWithValidVilleId()
        {
            var list_users = await (_db.Users.FromSqlRaw("Select * from dbo.Villes ").ToListAsync());
                                                                  



                return Ok(list_users);
        }

       
         [HttpPost]

         public async Task<IActionResult> LoginUser(UserDto _user)
        { 
            var list_users = await(from user in _db.Users

                                   select user).ToListAsync();

            foreach (User user in list_users)
            {
                if (user.email == _user.email)
                {
                    if (user.Password == _user.Password)
                    {
                        return Ok();
                    }
                    
                }
            }

            return NotFound();
        }



        // POST api/User/AddUser
        [HttpPost]
        public async Task<IActionResult> AddUser(User _user)
        {
            var user = new User
            {
                Name = _user.Name,
                LastName = _user.LastName,
                email = _user.email,
                Phone = _user.Phone,
                Adresse = _user.Adresse,
                Gender = _user.Gender,
                CodePostalUser = _user.CodePostalUser,
                Password = _user.Password,
                


        
            };
            uow.UserRepository.AddUser(user);
            await uow.SaveAsync();
           
            return StatusCode(201);
        }


        // PUT api/<VilleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VilleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
