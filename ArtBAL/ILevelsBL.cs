using ArtDTO.DTO;

namespace ArtBL
{
    public interface ILevelsBL
    {
        Task<List<LevelDTO>> GetLevels();
        Task<bool> AddLevels(LevelDTO leveldto);
        
        Task<bool> RemoveLevels(int levelId);

    }
}