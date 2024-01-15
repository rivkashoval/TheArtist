using ArtDL.Modelsa;

namespace ArtDL
{
    public interface IGaleryMasterDL
    {
        Task<List<GaleryMaster>> GetGaleryMaster();
        Task<bool> AddGaleryMaster(GaleryMaster galerymaster);
        Task<bool> RemoveGaleryMaster(int galerymasterId);
        Task<bool> UpdateGaleryMaster(GaleryMaster galerymaster, int galerymasterId);
    }
}