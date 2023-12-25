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
    public class UsersBL
    {
        private IUsersDL usersDl;

        IMapper _mapper;

        public UsersBL(IUsersDL usersDl, IMapper _mapper)
        {
            this.usersDl = usersDl;
        }

        public List<UserDTO> getUsers()
        {
            List<User> res = usersDl.GetUsers();
            List<UserDTO> users = _mapper.Map<List<UserDTO>>(res);
            return users;
        }


    }
}
