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
        private ArtProjectContext _ArtProjectContext = new ArtProjectContext();

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
                return null;
            }
        }


    }
}
