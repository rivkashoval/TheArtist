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
    public class LevelsBL : ILevelsBL
    {
        private ILevelsDL levelsDl;

        IMapper _mapper;

        public LevelsBL(ILevelsDL levelsDl, IMapper mapper)
        {
            this.levelsDl = levelsDl;
            this._mapper = mapper;
        }

        public async Task<List<LevelDTO>> GetLevels()
            
        {
            try
            {
                List<Level> res = await levelsDl.GetLevels();
                List<LevelDTO> levels = _mapper.Map<List<LevelDTO>>(res);
                return levels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<bool> AddLevels(LevelDTO leveldto)
        {
            try
            {

                Level level = _mapper.Map<Level>(leveldto);
                bool isAddLevels = await levelsDl.AddLevels(level);
                return isAddLevels;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }


        public async Task<bool> RemoveLevels(int levelId)
        {
            try
            {
                bool isRemoveLevels = await levelsDl.RemoveLevels(levelId);
                return isRemoveLevels;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
        public async Task<bool> UpdateLevels(LevelDTO leveldto, int levelId)
        {
            try
            {
                Level levelToUpdate = _mapper.Map<Level>(leveldto);//בשורה זו אני ממירה את היוזר ליוזר DTO
                bool isUpdate = await levelsDl.UpdateLevels(levelToUpdate, levelId);
                return isUpdate;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }


        }
    }



}