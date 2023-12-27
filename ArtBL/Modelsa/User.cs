using System;
using System.Collections.Generic;

namespace ArtDL.Modelsa
{
    public partial class User
    {
        public User()
        {
            CommentsGaleryJuniors = new HashSet<CommentsGaleryJunior>();
            GaleryJuniors = new HashSet<GaleryJunior>();
            GaleryMasters = new HashSet<GaleryMaster>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Mail { get; set; }
        public string? Password { get; set; }
        public int? LevelId { get; set; }
        public string? Desc { get; set; }

        public virtual Level? Level { get; set; }
        public virtual ICollection<CommentsGaleryJunior> CommentsGaleryJuniors { get; set; }
        public virtual ICollection<GaleryJunior> GaleryJuniors { get; set; }
        public virtual ICollection<GaleryMaster> GaleryMasters { get; set; }

        public bool AddUsers(User res)
        {
            throw new NotImplementedException();
        }
    }
}
