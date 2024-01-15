using ArtDL.Modelsa;

namespace ArtDL
{
    public interface IGaleryJuniorDL
    {
        Task<List<GaleryJunior>> GetGaleryJunior();
        Task<bool> AddGaleryJunior(GaleryJunior GaleryJunior);
        Task<bool> RemoveGaleryJunior(int GaleryJuniorId);
        Task<bool> UpdateGaleryJunior(GaleryJunior GaleryJunior, int GaleryJuniorId);
    }
}