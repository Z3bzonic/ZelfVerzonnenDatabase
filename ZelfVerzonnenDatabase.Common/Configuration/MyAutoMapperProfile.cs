using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZelfVerzonnenDatabase.Common.Models;
using ZelfVerzonnenDatabase.Entities;

namespace ZelfVerzonnenDatabase.Common.Configuration
{
    internal class MyAutoMapperProfile : Profile
    {
        public MyAutoMapperProfile()
        {
            CreateMap<Teacher, TeacherModel>()
                    .ForMember(x => x.Address, y => y.MapFrom(z => $"{z.Address.Street}, {z.Address.HouseNumber}"))
                    .ForMember(x => x.Voornaam, y => y.MapFrom(z => z.SurName)
                );
        }
    }
}