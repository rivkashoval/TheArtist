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
        public async Task<List<CommentsGaleryJunior>> GetCommentsGaleryJuniors()
        {
            try
            {
                List<CommentsGaleryJunior> commentsgaleryjuniors = await _ArtProjectContext.CommentsGaleryJuniors.ToListAsync();
                return commentsgaleryjuniors;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> AddCommentsGaleryJuniors(CommentsGaleryJunior commentsgaleryjuniors)
        {
            try
            {
                await _ArtProjectContext.CommentsGaleryJuniors.AddAsync(commentsgaleryjuniors);
                _ArtProjectContext.SaveChanges();
                return true;
            }

            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
        //מחיקה
        public async Task<bool> RemoveCommentsGaleryJuniors(int commentsgaleryjuniorId)
        {
            try
            {

                CommentsGaleryJunior commentsgaleryjuniors = await _ArtProjectContext.CommentsGaleryJuniors.FirstOrDefaultAsync(item => item.Id == commentsgaleryjuniorId);
                _ArtProjectContext.CommentsGaleryJuniors.Remove(commentsgaleryjuniors);
                await _ArtProjectContext.SaveChangesAsync();
                return true;
            }

            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

    }
}
