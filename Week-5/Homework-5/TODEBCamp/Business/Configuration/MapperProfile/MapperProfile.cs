using AutoMapper;
using DTO.Customer;
using Models.Entities;

namespace Bussines.Configuration.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CreateCustomerRequest, Customer>();
            CreateMap<UpdateCustomerRequest, Customer>();
            CreateMap<DeleteCustomerRequest, Customer>();

        }
    }
}