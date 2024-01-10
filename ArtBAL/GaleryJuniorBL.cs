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
                List<Glerygunure> res = await galeryJuniorDl.GetGaleryJunior();
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

                Glerygunure galeryJuniors = _mapper.Map<Glerygunure>(galeryJuniordto);
                bool isAddGaleryJunior = await galeryJuniorDl.AddGaleryJunior(galeryJuniors);
                return isAddGaleryJunior;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<bool> RemoveGaleryJunior(int glerygunureId)
        {
            try
            {
                //User user = _mapper.Map<User>(userId);
                bool isRemoveGaleryJunior = await galeryJuniorDl.RemoveGaleryJunior(glerygunureId);
                return isRemoveGaleryJunior;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
    }
}
