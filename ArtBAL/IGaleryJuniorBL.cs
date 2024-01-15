using ArtDTO.DTO;

namespace ArtBL
{
    public interface IGaleryJuniorBL
    {
        Task<List<GaleryJuniorDTO>> GetGaleryJunior();
        Task<bool> AddGaleryJunior(GaleryJuniorDTO galeryJuniordto);
        Task<bool> RemoveGaleryJunior(int GaleryJuniorId);
        Task<bool> UpdateGaleryJunior(GaleryJuniorDTO galeryJuniordto, int GaleryJuniorId);
    }
}