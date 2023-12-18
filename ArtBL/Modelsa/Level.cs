using System;
using System.Collections.Generic;

namespace ArtDL.Modelsa
{
    public partial class Level
    {
        public Level()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string? Desc { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
