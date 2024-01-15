using ArtDL.Modelsa;

namespace ArtDL
{
    public interface IGaleryMasterDL
    {
        Task<List<Glerymaster>> GetGaleryMaster();
        Task<bool> AddGaleryMaster(Glerymaster galerymaster);
        Task<bool> RemoveGaleryMaster(int galerymasterId);
        Task<bool> UpdateGaleryMaster(Glerymaster galerymaster, int galerymasterId);
    }
}