using ArtDTO.DTO;

namespace ArtBL
{
    public interface IUsersBL
    {
        Task<List<UserDTO>> getUsers();
        Task<bool> AddUsers(UserDTO userdto);
        Task<bool> RemoveUsers(int userId);
    }
}