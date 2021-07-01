using AutoMapper;
using AutoMapperAppPresents.Models;
using AutoMapperAppPresents.ViewModels;

namespace AutoMapperAppPresents
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap(typeof(User), typeof(UserViewModel));
            CreateMap(typeof(Product), typeof(ProductViewModel));
        }
    }
}
