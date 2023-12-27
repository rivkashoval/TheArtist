using ArtDL.Modelsa;

namespace ArtDL
{
    public interface IUsersDL
    {
        List<User> GetUsers();
        Task<bool> AddUsers(User user);
    }

}