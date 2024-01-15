using ArtDL.Modelsa;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtDL
{
    public class LevelsDL : ILevelsDL
    {
        private ArtProjectContext _ArtProjectContext;

        public LevelsDL(ArtProjectContext artProjectContext)
        {
            _ArtProjectContext = artProjectContext;
        }
        //get
        public async Task<List<Level>> GetLevels()
        {
            try
            {
                List<Level> levels = await _ArtProjectContext.Levels.ToListAsync();
                return levels;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> AddLevels(Level level)
        {
            try
            {
                await _ArtProjectContext.Levels.AddAsync(level);
                _ArtProjectContext.SaveChanges();
                return true;
            }

            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }


        public async Task<bool> RemoveLevels(int levelId)
        {
            try
            {

                Level level = await _ArtProjectContext.Levels.FirstOrDefaultAsync(item => item.Id == levelId);
                _ArtProjectContext.Levels.Remove(level);
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
        public async Task<bool> UpdateLevels(Level level, int levelId)

        {
            try
            {

                Level levelToUpdate = await _ArtProjectContext.Levels.Where(item => item.Id == levelId).FirstOrDefaultAsync();

                levelToUpdate.Desc=level.Desc;
                levelToUpdate.Id=levelId;
                _ArtProjectContext.Levels.Update(levelToUpdate);
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
