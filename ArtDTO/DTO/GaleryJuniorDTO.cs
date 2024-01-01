using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtDTO.DTO
{
    internal class GaleryJuniorDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Desc { get; set; }
        public DateTime? Date { get; set; }
        public int? UserId { get; set; }
        public string? Url { get; set; }
        public int? Like { get; set; }

    }
}
