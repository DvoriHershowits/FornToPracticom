using AutoMapper;
using Common.Dto_s;
using Repositories.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MappingProfileService:Profile
    {
        public MappingProfileService()
        {
            CreateMap<Child, ChildDto>().ReverseMap();
            CreateMap<Parent, ParentDto>().ReverseMap();
        }
    }
}
