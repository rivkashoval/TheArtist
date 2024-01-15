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

        // GET: api/<GaleryMasterController>
        [HttpGet]
        public async Task<List<GaleryMasterDTO>> Get()
        {
            return await _galeryMastersBl.GetGaleryMaster();
        }

        // POST api/<GaleryMasterController>
        [HttpPost]
        public async Task<bool> AddGaleryMaster([FromBody] GaleryMasterDTO galeryMasterdto)
        {
            return await _galeryMastersBl.AddGaleryMaster(galeryMasterdto);
        }

        // PUT api/<GaleryMasterController>/5
        [HttpPut("{id}")]
        public async Task<bool> UpdateGaleryMaster(GaleryMasterDTO galeryaMasterdto, int galeryMasterid)
        {

            return await _galeryMastersBl.UpdateGaleryMaster(galeryaMasterdto, galeryMasterid);

        }

        // DELETE api/<GaleryMasterController>/5
        [HttpDelete("{id}")]
        public async Task<bool> RemoveGaleryMaster(int galerymasterId)
        {
            return await _galeryMastersBl.RemoveGaleryMaster(galerymasterId);
        }
    }
}
