using ArtDTO.DTO;

namespace ArtBL
{
    public interface IGaleryMasterBL
    {
        Task<List<GaleryMasterDTO>> GetGaleryMaster();
        Task<bool> AddGaleryMaster(GaleryMasterDTO galeryMasterdto);
        Task<bool> RemoveGaleryMaster(int galerymasterId);
        Task<bool> UpdateGaleryMaster(GaleryMasterDTO galeryaMasterdto, int galeryMasterid);
    }
}