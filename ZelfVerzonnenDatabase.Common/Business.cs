using AutoMapper;
using ZelfVerzonnenDatabase.Common.Models;
using ZelfVerzonnenDatabase.DAL.Repositories;
using ZelfVerzonnenDatabase.Entities;

namespace ZelfVerzonnenDatabase.Common
{
    public class Business
    {
        private BaseRepository<Teacher> _repo;
        private IMapper _mapper;

        public Business()
        {
            _repo = new BaseRepository<Teacher>();
            var config = new MapperConfiguration
                (
                    cfg => cfg.CreateMap<Teacher, TeacherModel>()
                    .ForMember(x => x.Address, y => y.MapFrom(z => $"{z.Address.Street}, {z.Address.HouseNumber}"))
                    .ForMember(x => x.Voornaam, y => y.MapFrom(z => z.SurName))
                );
            _mapper = new Mapper(config);
        }

        public async Task<TeacherModel> GetTeacherAsync()
        {
            Teacher entity = await _repo.GetAsync(1);
            TeacherModel model = _mapper.Map<TeacherModel>(entity);

            return model;
        }

        private Teacher GetDummyEntity()
        {
            return new Teacher
            {
                Id = 1,
                Name = "Jommeké",
                SurName = "Gertrude",
                Age = 99,
                Address = new Address
                {
                    Street = "Helicoterstraat",
                    HouseNumber = "9999"
                }
            };
        }
    }
}