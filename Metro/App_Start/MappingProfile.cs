using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Metro.Dtos;
using Metro.Models;

namespace Metro.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<HumanDto, Human>().ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<Human, HumanDto>();

        }
    }
}