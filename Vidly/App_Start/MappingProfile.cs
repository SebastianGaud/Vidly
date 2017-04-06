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
            Mapper.CreateMap<Customer , CustomerDTO>()
                .ForMember( c => c.Id , opt => opt.Ignore() );
            Mapper.CreateMap<Movie , MovieDTO>()
                .ForMember( m => m.Id , opt => opt.Ignore() );

            Mapper.CreateMap<MembershipType , MembershipTypeDTO>();



            //DTO to Model
            Mapper.CreateMap<CustomerDTO , Customer>();

            Mapper.CreateMap<MovieDTO , Movie>();
        }
    }
}