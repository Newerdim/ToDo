using AutoMapper;

namespace ToDo.API.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Entities.User, Dto.User>();
        }
    }
}