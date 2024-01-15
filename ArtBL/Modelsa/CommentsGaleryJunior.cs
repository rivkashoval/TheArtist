using System;
using System.Collections.Generic;

namespace ArtDL.Modelsa
{
    public partial class CommentsGaleryJunior
    {
        public int Id { get; set; }
        public string? Desc { get; set; }
        public DateTime? Date { get; set; }
        public int? UserId { get; set; }

        public virtual User? User { get; set; }
    }
}
