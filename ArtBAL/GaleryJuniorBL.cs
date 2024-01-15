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
    public class GaleryJuniorBL : IGaleryJuniorBL
    {
        private IGaleryJuniorDL galeryJuniorDl;

        IMapper _mapper;

        public GaleryJuniorBL(IGaleryJuniorDL galeryJuniorDl, IMapper mapper)
        {
            this.galeryJuniorDl = galeryJuniorDl;
            this._mapper = mapper;
        }

        public async Task<List<GaleryJuniorDTO>> GetGaleryJunior()
        {
            try
            {
                List<GaleryJunior> res = await galeryJuniorDl.GetGaleryJunior();
                List<GaleryJuniorDTO> galeryJuniors = _mapper.Map<List<GaleryJuniorDTO>>(res);
                return galeryJuniors;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> AddGaleryJunior(GaleryJuniorDTO galeryJuniordto)
        {
            try
            {

                GaleryJunior galeryJuniors = _mapper.Map<GaleryJunior>(galeryJuniordto);
                bool isAddGaleryJunior = await galeryJuniorDl.AddGaleryJunior(galeryJuniors);
                return isAddGaleryJunior;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<bool> RemoveGaleryJunior(int GaleryJuniorId)
        {
            try
            {
                //User user = _mapper.Map<User>(userId);
                bool isRemoveGaleryJunior = await galeryJuniorDl.RemoveGaleryJunior(GaleryJuniorId);
                return isRemoveGaleryJunior;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
        public async Task<bool> UpdateGaleryJunior(GaleryJuniorDTO galeryJuniordto, int GaleryJuniorId)
        {
            try
            {
                GaleryJunior GaleryJuniorToUpdate = _mapper.Map<GaleryJunior>(galeryJuniordto);//בשורה זו אני ממירה את היוזר ליוזר DTO
                bool isUpdate = await galeryJuniorDl.UpdateGaleryJunior(GaleryJuniorToUpdate, GaleryJuniorId);
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
