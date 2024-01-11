using ArtBL;
using ArtDTO.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheArtist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        IContactsBL _contactsBl;
        public ContactsController(IContactsBL contactsBl)
        {
            _contactsBl = contactsBl;
        }
        // GET: api/<ContactsController>
        [HttpGet]
        public async Task<List<ContactDTO>> GetContacts()
        {
            return await _contactsBl.GetContacts();
        }

     
        // POST api/<ContactsController>
        [HttpPost]
        public async Task<bool> AddContacts([FromBody] ContactDTO contactdto)
        {
            return await _contactsBl.AddContacts(contactdto);
        }


        // PUT api/<ContactsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContactsController>/5
        [HttpDelete("{id}")]
        public async Task<bool> RemoveContacts(int contactId)
        {
            return await _contactsBl.RemoveContacts(contactId);
        }
    }
}
