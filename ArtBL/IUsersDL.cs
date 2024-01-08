using ArtDL.Modelsa;

namespace ArtDL
{
    public interface IUsersDL
    {
        Task<List<User>> GetUsers();
        Task<bool> AddUsers(User user);
        Task<bool> RemoveUsers(int userId);
        Task<bool> UpdateUsers(User user, int userId);
    }

}