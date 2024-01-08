using System;
using System.Collections.Generic;

namespace ArtDL.Modelsa
{
    public partial class User
    {
        public User()
        {
            Commentsgaleryjuniors = new HashSet<Commentsgaleryjunior>();
            Glerygunures = new HashSet<Glerygunure>();
            Glerymasters = new HashSet<Glerymaster>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Mail { get; set; }
        public string? Password { get; set; }
        public int? LevelId { get; set; }
        public string? Desc { get; set; }
        public string? IdentityNumber { get; set; }

        public virtual ICollection<Commentsgaleryjunior> Commentsgaleryjuniors { get; set; }
        public virtual ICollection<Glerygunure> Glerygunures { get; set; }
        public virtual ICollection<Glerymaster> Glerymasters { get; set; }
    }
}
