#region Usings
using AutoMapper;
using PersonAPI.Dtos;
using PersonAPI.Models;
#endregion

namespace PersonAPI.Profiles
{
    public class PeopleProfile : Profile
    {
        public PeopleProfile()
        {
            // Source -> Destination
            CreateMap<Person, PersonReadDto>()
                .ForMember(dest => dest.Age , opt => opt.MapFrom<AgeResolver>());
            CreateMap<PersonCreateDto, Person>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(new FullNameResolver()!))
                .ForMember(dest => dest.House, opt => opt.NullSubstitute("Hufflepuff"));
            CreateMap<PersonUpdateDto, Person>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FirstName + ' ' + src.LastName));
            CreateMap<string, int>().ConvertUsing<IntTypeConverter>();
        }
    }
}