using ArtDL.Modelsa;
using ArtDL;
using ArtDTO.DTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtBL
{
    public class CommentsGaleryJuniorBL : ICommentsGaleryJuniorBL
    {
        private ICommentsGaleryJuniorDL commentsGaleryJuniorsDl;

        IMapper _mapper;

        public CommentsGaleryJuniorBL(ICommentsGaleryJuniorDL commentsGaleryJuniorsDl, IMapper mapper)
        {
            this.commentsGaleryJuniorsDl = commentsGaleryJuniorsDl;
            this._mapper = mapper;
        }

        public async Task<List<CommentsGaleryJuniorDTO>> GetCommentsgaleryjuniors()
        {
            try
            {
                List<Commentsgaleryjunior> res = await commentsGaleryJuniorsDl.GetCommentsgaleryjuniors();
                List<CommentsGaleryJuniorDTO> commentsGaleryJuniors = _mapper.Map<List<CommentsGaleryJuniorDTO>>(res);
                return commentsGaleryJuniors;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
