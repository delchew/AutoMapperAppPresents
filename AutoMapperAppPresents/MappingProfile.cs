using AutoMapper;
using AutoMapperAppPresents.Models;
using AutoMapperAppPresents.ViewModels;

namespace AutoMapperAppPresents
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap(typeof(User), typeof(UserViewModel)).ReverseMap();
            CreateMap(typeof(Product), typeof(ProductViewModel)).ReverseMap();
        }
    }
}
