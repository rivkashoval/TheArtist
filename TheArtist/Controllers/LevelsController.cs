using ArtBL;
using ArtDTO.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheArtist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LevelsController : ControllerBase
    {
        //// GET: api/<LevelsController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<LevelsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        ILevelsBL _levelsBl;
        public LevelsController(ILevelsBL levelsBl)
        {
            _levelsBl = levelsBl;
        }
        [HttpGet]
        public async Task<List<LevelDTO>> Get()
        {
            return await _levelsBl.GetLevels();
        }



        // POST api/<LevelsController>
        [HttpPost]
        public async Task<bool> AddLevels([FromBody] LevelDTO leveldto)
        {
            return await _levelsBl.AddLevels(leveldto);
        }

        // PUT api/<LevelsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LevelsController>/5
        [HttpDelete]
        public async Task<bool> RemoveLevels(int levelId)
        {
            return await _levelsBl.RemoveLevels(levelId);
        }

    }
}
