using AutoMapper;
using Vidly.DTOS;
using Vidly.Models;

namespace Vidly
{
    public class MappingProfile : Profile
    {
        public MappingProfile ()
        {
            //MODEL to DTO
            Mapper.CreateMap<Customer , CustomerDTO>();

            Mapper.CreateMap<Movie , MovieDTO>();

            Mapper.CreateMap<MembershipType , MembershipTypeDTO>();



            //DTO to Model
            Mapper.CreateMap<CustomerDTO , Customer>()
                .ForMember( c => c.Id , opt => opt.Ignore() );

            Mapper.CreateMap<MovieDTO , Movie>()
                .ForMember( c => c.Id , opt => opt.Ignore() );
        }
    }
}