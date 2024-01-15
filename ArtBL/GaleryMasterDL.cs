using ArtDL.Modelsa;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ArtDL
{
    public class GaleryMasterDL : IGaleryMasterDL
    {
        private ArtProjectContext _ArtProjectContext;

        public GaleryMasterDL(ArtProjectContext artProjectContext)
        {
            _ArtProjectContext = artProjectContext;
        }
        //get
        public async Task<List<GaleryMaster>> GetGaleryMaster()
        {
            try
            {
                List<GaleryMaster> galeryMaster =await _ArtProjectContext.GaleryMasters.ToListAsync();
                return galeryMaster;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //הוספה
        public async Task<bool> AddGaleryMaster(GaleryMaster galerymaster)
        {
            try
            {
                await _ArtProjectContext.GaleryMasters.AddAsync(galerymaster);
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
        public async Task<bool> RemoveGaleryMaster(int galerymasterId)
        {
            try
            {

                GaleryMaster galerymaster = await _ArtProjectContext.GaleryMasters.FirstOrDefaultAsync(item => item.Id == galerymasterId);
                _ArtProjectContext.GaleryMasters.Remove(galerymaster);
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
        public async Task<bool> UpdateGaleryMaster(GaleryMaster galerymaster, int galerymasterId)

        {
            try
            {

                GaleryMaster galerymasterToUpdate = await _ArtProjectContext.GaleryMasters.Where(item => item.Id == galerymasterId).FirstOrDefaultAsync();
                galerymasterToUpdate.Name = galerymasterToUpdate.Name;
                galerymasterToUpdate.Desc= galerymaster.Desc;
                galerymasterToUpdate.Year = galerymasterToUpdate.Year;
                galerymasterToUpdate.UserId = galerymasterToUpdate.UserId;
                galerymasterToUpdate.Url = galerymasterToUpdate.Url;    
                _ArtProjectContext.GaleryMasters.Update(galerymasterToUpdate);

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
