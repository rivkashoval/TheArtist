using ArtBL;
using ArtDTO.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheArtist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsGaleryJuniorController : ControllerBase

    {
        ICommentsGaleryJuniorBL _commentsGaleryJuniorsBl;
        public CommentsGaleryJuniorController(ICommentsGaleryJuniorBL commentsGaleryJuniorsBl)
        {
            _commentsGaleryJuniorsBl = commentsGaleryJuniorsBl;
        }
        // GET: api/<COMMENTSGALERYJUNIORController>
        [HttpGet]
        public async Task<List<CommentsGaleryJuniorDTO>> GetCommentsgaleryjuniors()
        {
            return await _commentsGaleryJuniorsBl.GetCommentsgaleryjuniors();
        }

        // POST api/<COMMENTSGALERYJUNIORController>
        [HttpPost]
        public async Task<bool> AddCommentsgaleryjuniors([FromBody] CommentsGaleryJuniorDTO commentsGaleryJuniorDTO)
        {
            return await _commentsGaleryJuniorsBl.AddCommentsgaleryjuniors(commentsGaleryJuniorDTO);
        }
        // PUT api/<COMMENTSGALERYJUNIORController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<COMMENTSGALERYJUNIORController>/5
        [HttpDelete("{id}")]
        public async Task<bool> RemoveCommentsgaleryjuniors(int commentsgaleryjuniorId)
        {
            return await _commentsGaleryJuniorsBl.RemoveCommentsgaleryjuniors(commentsgaleryjuniorId);
        }
    }
}
