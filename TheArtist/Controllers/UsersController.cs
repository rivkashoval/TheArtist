﻿using ArtBL;
using ArtDL;
using ArtDL.Modelsa;
using ArtDTO.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheArtist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUsersBL usersBl;
        public UsersController(IUsersBL usersBl)
        {
            usersBl = usersBl;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public async Task<List<UserDTO>> Get()
        {
            return await usersBl.getUsers();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersController>
        [HttpPost]
        public async Task<bool> AddUsers([FromBody] UserDTO userdto)
        {
           return await usersBl.AddUsers(userdto);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public async Task<bool> RemoveUsers(int userId)
        {
            return await usersBl.RemoveUsers(userId);
        }
    }
}
