using ArtDL.Modelsa;
using ArtDL;
using ArtDTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace ArtBL
{
    public class GaleryMasterBL : IGaleryMasterBL
    {
        private IGaleryMasterDL galeryMasterDl;

        IMapper _mapper;

        public GaleryMasterBL(IGaleryMasterDL galeryMasterDl, IMapper mapper)
        {
            this.galeryMasterDl = galeryMasterDl;
            this._mapper = mapper;
        }

        public async Task<List<GaleryMasterDTO>> GetGaleryMaster()
        {
            try
            {
                List<GaleryMaster> res = await galeryMasterDl.GetGaleryMaster();
                List<GaleryMasterDTO> users = _mapper.Map<List<GaleryMasterDTO>>(res);
                return users;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<bool> AddGaleryMaster(GaleryMasterDTO galeryMasterdto)
        {
            try
            {

                GaleryMaster galeryMaster = _mapper.Map<GaleryMaster>(galeryMasterdto);
                bool isAddGaleryMaster = await galeryMasterDl.AddGaleryMaster(galeryMaster);
                return isAddGaleryMaster;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<bool> RemoveGaleryMaster(int galerymasterId)
        {
            try
            {
                bool RemoveGaleryMaster = await galeryMasterDl.RemoveGaleryMaster(galerymasterId);
                return RemoveGaleryMaster;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        public async Task<bool> UpdateGaleryMaster(GaleryMasterDTO galeryaMasterdto, int galeryMasterid)
        {
            try
            {
                GaleryMaster galeryMasterToUpdate = _mapper.Map<GaleryMaster>(galeryaMasterdto);//בשורה זו אני ממירה את היוזר ליוזר DTO
                bool isUpdate = await galeryMasterDl.UpdateGaleryMaster(galeryMasterToUpdate, galeryMasterid);
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
