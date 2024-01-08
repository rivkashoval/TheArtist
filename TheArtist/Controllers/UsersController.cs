using ArtBL;
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
        IUsersBL _usersBl;
        public UsersController(IUsersBL usersBl)
        {
            _usersBl = usersBl;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public async Task<List<UserDTO>> Get()
        {
            return await _usersBl.getUsers();
        }

        
        // POST api/<UsersController>
        [HttpPost]
        public async Task<bool> AddUsers([FromBody] UserDTO userdto)
        {
           return await _usersBl.AddUsers(userdto);
        }

        // PUT api/<UsersController>/5
        [HttpPut]
        public async Task<bool> UpdateUsers(UserDTO userdto, int userId)
        {

            return await _usersBl.UpdateUsers(userdto, userId);
            
        }

       



        // DELETE api/<UsersController>/5
        [HttpDelete]
        public async Task<bool> RemoveUsers(int userId)
        {
            return await  _usersBl.RemoveUsers(userId);
        }


    }
}
