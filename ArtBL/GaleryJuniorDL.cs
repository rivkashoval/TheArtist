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
        public async Task<List<GaleryJunior>> GetGaleryJunior()
        {
            try
            {
                List<GaleryJunior> GaleryJunior = await _ArtProjectContext.GaleryJuniors.ToListAsync();    
                return GaleryJunior;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //הוספה
        public async Task<bool> AddGaleryJunior(GaleryJunior GaleryJunior)
        {
            try
            {
                await _ArtProjectContext.GaleryJuniors.AddAsync(GaleryJunior);
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
        public async Task<bool> RemoveGaleryJunior(int GaleryJuniorId)
        {
            try
            {
                GaleryJunior GaleryJunior = await _ArtProjectContext.GaleryJuniors.FirstOrDefaultAsync(item => item.Id == GaleryJuniorId);
                _ArtProjectContext.GaleryJuniors.Remove(GaleryJunior);
                await _ArtProjectContext.SaveChangesAsync();
                return true;
            }

            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
        //עדכון
        public async Task<bool> UpdateGaleryJunior(GaleryJunior GaleryJunior, int GaleryJuniorId)

        {
            try
            {

                GaleryJunior GaleryJuniorToUpdate = await _ArtProjectContext.GaleryJuniors.Where(item => item.Id == GaleryJuniorId).FirstOrDefaultAsync();

                GaleryJuniorToUpdate.Name=GaleryJunior.Name;
                GaleryJuniorToUpdate.Desc=GaleryJunior.Desc;
                GaleryJuniorToUpdate.Date=GaleryJunior.Date;
                GaleryJuniorToUpdate.UserId=GaleryJunior.UserId;
                GaleryJuniorToUpdate.Url=GaleryJunior.Url;
                GaleryJuniorToUpdate.Like=GaleryJunior.Like;  


                _ArtProjectContext.GaleryJuniors.Update(GaleryJuniorToUpdate);

                await _ArtProjectContext.SaveChangesAsync();
                return true;

            }

            catch (Exception ex)

            {

                throw ex;

            }


        }


    }
}
