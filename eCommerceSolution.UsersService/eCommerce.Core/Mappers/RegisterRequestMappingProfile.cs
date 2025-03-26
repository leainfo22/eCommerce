using AutoMapper;
using eCommerce.Core.DTO;
using eCommerce.Core.Entities;

namespace eCommerce.Core.Mappers;

public class RegisterRequestMappingProfile : Profile
{
    public RegisterRequestMappingProfile()
    {
        CreateMap<RegisterRequest, ApplicationUser>().            
            ForMember(desti => desti.Email, opt => opt.MapFrom(src => src.Email)).
            ForMember(desti => desti.PersonName, opt => opt.MapFrom(src => src.PersonName)).
            ForMember(desti => desti.Password, opt => opt.MapFrom(src => src.Password)).
            ForMember(desti => desti.Gender, opt => opt.MapFrom(src => src.Gender.ToString()));
    }
}

