﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtDTO.DTO
{
    public class GaleryMasterDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Desc { get; set; }
        public int? Year { get; set; }
        public int? UserId { get; set; }
        public string? Url { get; set; }

    }
}
