using AutoMapper;
using VidlyApp.Dtos;
using VidlyApp.Models;

namespace VidlyApp.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, x => x.Ignore()); ;

            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MovieDto, Movie>().ForMember(m => m.Id, x => x.Ignore()); ;
        }
    }
}