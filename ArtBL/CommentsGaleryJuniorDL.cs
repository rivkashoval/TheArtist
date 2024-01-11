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

        public async Task<bool> AddCommentsgaleryjuniors(Commentsgaleryjunior commentsgaleryjuniors)
        {
            try
            {
                await _ArtProjectContext.Commentsgaleryjuniors.AddAsync(commentsgaleryjuniors);
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
        public async Task<bool> RemoveCommentsgaleryjuniors(int commentsgaleryjuniorId)
        {
            try
            {

                Commentsgaleryjunior commentsgaleryjuniors = await _ArtProjectContext.Commentsgaleryjuniors.FirstOrDefaultAsync(item => item.Id == commentsgaleryjuniorId);
                _ArtProjectContext.Commentsgaleryjuniors.Remove(commentsgaleryjuniors);
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
