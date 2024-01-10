using ArtBL;
using ArtDTO.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheArtist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaleryMasterController : ControllerBase
    {
        IGaleryMasterBL _galeryMastersBl;
        public GaleryMasterController(IGaleryMasterBL galeryMastersBl)
        {
            _galeryMastersBl = galeryMastersBl;
        }

        // GET: api/<GleryMasterController>
        [HttpGet]
        public async Task<List<GaleryMasterDTO>> Get()
        {
            return await _galeryMastersBl.GetGaleryMaster();
        }

        // POST api/<GleryMasterController>
        [HttpPost]
        public async Task<bool> AddGaleryMaster([FromBody] GaleryMasterDTO galeryMasterdto)
        {
            return await _galeryMastersBl.AddGaleryMaster(galeryMasterdto);
        }

        // PUT api/<GleryMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GleryMasterController>/5
        [HttpDelete("{id}")]
        public async Task<bool> RemoveGaleryMaster(int galerymasterId)
        {
            return await _galeryMastersBl.RemoveGaleryMaster(galerymasterId);
        }
    }
}
