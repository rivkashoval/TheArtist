using ArtDL.Modelsa;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtDL
{
    public class GaleryJuniorDL : IGaleryJuniorDL
    {
        private ArtProjectContext _ArtProjectContext;

        public GaleryJuniorDL(ArtProjectContext artProjectContext)
        {
            _ArtProjectContext = artProjectContext;
        }
        //get
        public async Task<List<Glerygunure>> GetGaleryJunior()
        {
            try
            {
                List<Glerygunure> glerygunure = await _ArtProjectContext.Glerygunures.ToListAsync();    
                return glerygunure;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //הוספה
        public async Task<bool> AddGaleryJunior(Glerygunure glerygunure)
        {
            try
            {
                await _ArtProjectContext.Glerygunures.AddAsync(glerygunure);
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
        public async Task<bool> RemoveGaleryJunior(int glerygunureId)
        {
            try
            {
                Glerygunure glerygunure = await _ArtProjectContext.Glerygunures.FirstOrDefaultAsync(item => item.Id == glerygunureId);
                _ArtProjectContext.Glerygunures.Remove(glerygunure);
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
