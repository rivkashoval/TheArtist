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

        public List<UserDTO> getUsers()
        {
            List<User> res = usersDl.GetUsers();
            List<UserDTO> users = _mapper.Map<List<UserDTO>>(res);
            return users;
        }

        public async Task<bool> AddUsers(UserDTO userdto)
        {
            try
            {

                User user = _mapper.Map<User>(userdto);
                bool isAddUsers =await usersDl.AddUsers(user);
                return isAddUsers;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }


    }
}
