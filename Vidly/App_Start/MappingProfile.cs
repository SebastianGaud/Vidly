using AutoMapper;
using Vidly.DTOS;
using Vidly.Models;

namespace Vidly
{
    public class MappingProfile : Profile
    {
        public MappingProfile ()
        {
            Mapper.CreateMap<Customer , CustomerDTO>();
            Mapper.CreateMap<CustomerDTO , Customer>();
            Mapper.CreateMap<Movie , MovieDTO>();
            Mapper.CreateMap<MovieDTO , Movie>();
        }
    }
}