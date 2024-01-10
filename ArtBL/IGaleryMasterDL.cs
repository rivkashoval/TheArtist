using ArtDL.Modelsa;

namespace ArtDL
{
    public interface IGaleryMasterDL
    {
        Task<List<Glerymaster>> GetGaleryMaster();
        Task<bool> AddGaleryMaster(Glerymaster galerymaster);
        Task<bool> RemoveGaleryMaster(int galerymasterId);
    }
}