using AutoMapper;
using eCommerce.Core.DTO;
using eCommerce.Core.Entities;

namespace eCommerce.Core.Mappers;
public class ApplicationUserMappingProfile : Profile
{
    public ApplicationUserMappingProfile() 
    {
        CreateMap<ApplicationUser, AuthenticationResponse>().
            ForMember(desti => desti.UserID, opt => opt.MapFrom(src => src.UserID)).
            ForMember(desti => desti.Email, opt => opt.MapFrom(src => src.Email)).            
            ForMember(desti => desti.PersonName, opt => opt.MapFrom(src => src.PersonName)).
            ForMember(desti => desti.Gender, opt => opt.MapFrom(src => src.Gender)).
            ForMember(desti => desti.Success, opt => opt.Ignore()).
            ForMember(desti => desti.Token, opt => opt.Ignore());
    }
}

