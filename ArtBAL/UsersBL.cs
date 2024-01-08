using ArtDL;
using ArtDL.Modelsa;
using ArtDTO;
using ArtDTO.DTO;
using AutoMapper;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArtBL
{
    public class UsersBL : IUsersBL
    {

        private IUsersDL usersDl;

        IMapper _mapper;

        public UsersBL(IUsersDL usersDl, IMapper mapper)
        {
            this.usersDl = usersDl;
            this._mapper = mapper;
        }

        public async Task<List<UserDTO>> getUsers()
        {
            try { 
            List<User> res = await usersDl.GetUsers();
            List<UserDTO> users = _mapper.Map<List<UserDTO>>(res);
            return users;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> AddUsers(UserDTO userdto)
        {
            try
            {

                User user = _mapper.Map<User>(userdto);
                bool isAddUsers = await usersDl.AddUsers(user);
                return isAddUsers;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<bool> RemoveUsers(int userId)
        {
            try
            {
                User user = _mapper.Map<User>(userId);
                bool isRemoveUsers = await usersDl.RemoveUsers(userId);
                return isRemoveUsers;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        public async Task<bool> UpdateUsers(UserDTO userdto, int userId)
        {
            try { 
                User userToUpdate = _mapper.Map<User>(userdto);//בשורה זו אני ממירה את היוזר ליוזר DTO
                bool isUpdate =await usersDl.UpdateUsers(userToUpdate, userId);
                return isUpdate;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
