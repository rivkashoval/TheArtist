using ArtDL.Modelsa;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtDL
{
    public class CommentsGaleryJuniorDL : ICommentsGaleryJuniorDL
    {
        private ArtProjectContext _ArtProjectContext;

        public CommentsGaleryJuniorDL(ArtProjectContext artProjectContext)
        {
            _ArtProjectContext = artProjectContext;
        }
        //get
        public async Task<List<Commentsgaleryjunior>> GetCommentsgaleryjuniors()
        {
            try
            {
                List<Commentsgaleryjunior> commentsgaleryjuniors = await _ArtProjectContext.Commentsgaleryjuniors.ToListAsync();
                return commentsgaleryjuniors;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
