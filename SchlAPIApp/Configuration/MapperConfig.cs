using AutoMapper;
using SchlAPIApp.Data;
using SchlAPIApp.DTO;

namespace UsersStudentsMVCApp.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<User, UserPatchDTO>().ReverseMap();
            CreateMap<User, UserSignupDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserReadOnlyDTO>().ReverseMap();
            CreateMap<User, UserTeacherReadOnlyDTO>()
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => $"{src.Teacher!.PhoneNumber}"))
                .ForMember(dest => dest.Institution, opt => opt.MapFrom(src => $"{src.Teacher!.Institution}")).ReverseMap();
        }
    }
}
