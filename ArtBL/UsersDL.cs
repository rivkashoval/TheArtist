using ArtDL.Modelsa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtDL
{
    public class UsersDL : IUsersDL
    {
        private ArtProjectContext _ArtProjectContext;

        public UsersDL(ArtProjectContext artProjectContext)
        {
            _ArtProjectContext = artProjectContext;
        }

        public List<User> GetUsers()
        {
            try
            {
                var users = _ArtProjectContext.Users.ToList();
                return users;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> AddUsers(User user)
        {
            try
            {
               await _ArtProjectContext.Users.AddAsync(user);
                _ArtProjectContext.SaveChanges();
                return true;
            }

            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }


    }
}
