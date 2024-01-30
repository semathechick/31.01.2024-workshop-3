using AutoMapper;
using Business.Responses.Customers;
using Entities.Concrete;


namespace Business.Profiles.Mapping.AutoMapper
{
    public class CustomersMapperProfile : Profile
    {
        public CustomersMapperProfile() 
        {
            CreateMap<AddCustomerRequest, Customer>();
            CreateMap<Customer, AddCustomerResponse>();

            CreateMap<Customer, CustomerListItemDto>();
            CreateMap<IList<Customer>, GetCustomerListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));



            CreateMap<Customer, GetCustomerByIdResponse>();
        }
        
    }
}
