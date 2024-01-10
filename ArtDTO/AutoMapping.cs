using ArtDL.Modelsa;
using ArtDTO.DTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtDTO
{
    public class AutoMapping :Profile
    {
        public AutoMapping()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Level, LevelDTO>().ReverseMap();
            CreateMap<Glerymaster, GaleryMasterDTO>().ReverseMap();
            CreateMap<Glerygunure, GaleryJuniorDTO>().ReverseMap();
        }


    }
}
