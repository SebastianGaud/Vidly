using AutoMapper;
using Vidly.DTOS;
using Vidly.Models;

namespace Vidly
{
    public class MappingProfile : Profile
    {
        public MappingProfile ()
        {
            Mapper.CreateMap<Customer , CustomerDTO>()
                .ForMember( c => c.Id , opt => opt.Ignore() );

            Mapper.CreateMap<CustomerDTO , Customer>();


            Mapper.CreateMap<Movie , MovieDTO>()
                .ForMember( m => m.Id , opt => opt.Ignore() );

            Mapper.CreateMap<MovieDTO , Movie>();
        }
    }
}