using ArtDL.Modelsa;

namespace ArtDL
{
    public interface IGaleryJuniorDL
    {
        Task<List<Glerygunure>> GetGaleryJunior();
        Task<bool> AddGaleryJunior(Glerygunure glerygunure);
        Task<bool> RemoveGaleryJunior(int glerygunureId);
    }
}