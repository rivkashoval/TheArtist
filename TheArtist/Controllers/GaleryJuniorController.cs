using ArtBL;
using ArtDTO.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheArtist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaleryJuniorController : ControllerBase
    {
        IGaleryJuniorBL _galeryJuniorBl;
        public GaleryJuniorController(IGaleryJuniorBL galeryJuniorBl)
        {
            _galeryJuniorBl = galeryJuniorBl;
        }
        // GET: api/<GleryYunuresController>
        [HttpGet]
        public async Task<List<GaleryJuniorDTO>> GetGaleryJunior()
        {
            return await _galeryJuniorBl.GetGaleryJunior();
        }


    

        // POST api/<GleryYunuresController>
        [HttpPost]
        public async Task<bool> AddGaleryJunior([FromBody] GaleryJuniorDTO galeryJuniordto)
        {
            return await _galeryJuniorBl.AddGaleryJunior(galeryJuniordto);
        }

        // PUT api/<GleryYunuresController>/5
        [HttpPut("{id}")]
        public async Task<bool> UpdateGaleryJunior(GaleryJuniorDTO galeryJuniordto, int GaleryJuniorId)
        {

            return await _galeryJuniorBl.UpdateGaleryJunior(galeryJuniordto, GaleryJuniorId);

        }

        // DELETE api/<GleryYunuresController>/5
        [HttpDelete("{id}")]
        public async Task<bool> RemoveGaleryJunior(int GaleryJuniorId)
        {
            return await _galeryJuniorBl.RemoveGaleryJunior(GaleryJuniorId);
        }
    }
}
