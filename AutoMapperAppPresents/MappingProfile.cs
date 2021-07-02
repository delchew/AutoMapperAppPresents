using AutoMapper;
using AutoMapperAppPresents.Models;
using AutoMapperAppPresents.ViewModels;

namespace AutoMapperAppPresents
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>().ForMember("UserName", opt => opt.MapFrom(u => u.Name + " " + u.Surname));
            CreateMap<Product, ProductViewModel>().ReverseMap();
        }
    }
}
