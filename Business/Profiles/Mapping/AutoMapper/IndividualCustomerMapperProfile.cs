
using AutoMapper;
using Business.Requests.IndividualCustomer;
using Business.Responses.IndividualCustomer;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class IndividualCustomerMapperProfile : Profile
    {
        public IndividualCustomerMapperProfile() 
        {
            CreateMap<AddIndividualCustomerRequest, IndividualCustomer>();
            CreateMap<IndividualCustomer, AddIndividualCustomerResponse>();

        }

    }
}
