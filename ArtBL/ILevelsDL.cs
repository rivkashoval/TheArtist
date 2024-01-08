using ArtDL.Modelsa;

namespace ArtDL
{
    public interface ILevelsDL
    {
        Task<List<Level>> GetLevels();
        Task<bool> AddLevels(Level level);
        Task<bool> RemoveLevels(int levelId);
    }
}