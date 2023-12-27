using ArtDL.Modelsa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtDTO.DTO
{
    public class UserDTO
    {

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Mail { get; set; }
        public string? Password { get; set; }
        public int? LevelId { get; set; }
        public string? Desc { get; set; }

        public bool AddUsers(User res)
        {
            throw new NotImplementedException();
        }

        //public virtual LevelDTO? Level { get; set; }
    }
}
