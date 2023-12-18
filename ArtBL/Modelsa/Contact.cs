using System;
using System.Collections.Generic;

namespace ArtDL.Modelsa
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? Phone { get; set; }
        public string? DetaIls { get; set; }
        public DateTime? Date { get; set; }
    }
}
