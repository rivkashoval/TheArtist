using ArtDL.Modelsa;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<List<Glerymaster>> GetGaleryMaster()
        {
            try
            {
                List<Glerymaster> galeryMaster =await _ArtProjectContext.Glerymasters.ToListAsync();
                return galeryMaster;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //הוספה
        public async Task<bool> AddGaleryMaster(Glerymaster galerymaster)
        {
            try
            {
                await _ArtProjectContext.Glerymasters.AddAsync(galerymaster);
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

                Glerymaster galerymaster = await _ArtProjectContext.Glerymasters.FirstOrDefaultAsync(item => item.Id == galerymasterId);
                _ArtProjectContext.Glerymasters.Remove(galerymaster);
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
