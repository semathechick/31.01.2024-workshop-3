using AutoMapper;
using Business.Requests.CorporateCustomer;
using Business.Responses.CorporateCustomer;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class CorporateCustomerMapperProfile : Profile
    {
        public CorporateCustomerMapperProfile()
        {
            CreateMap<AddCorporateCustomerRequest, CorporateCustomer>();
            CreateMap<CorporateCustomer, AddCorporateCustomerResponse>();

            CreateMap<CorporateCustomer, CorporateCustomerListItemDto>();
            CreateMap<IList<CorporateCustomer>, GetCorporateCustomerListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));



            CreateMap<CorporateCustomer, GetCorporateCustomerByIdResponse>();
        }

    }
}
