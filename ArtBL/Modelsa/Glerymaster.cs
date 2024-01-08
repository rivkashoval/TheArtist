using System;
using System.Collections.Generic;

namespace ArtDL.Modelsa
{
    public partial class Glerymaster
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Desc { get; set; }
        public int? Year { get; set; }
        public int? UserId { get; set; }
        public string? Url { get; set; }

        public virtual User? User { get; set; }
    }
}
