using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.CorporateCustomer;
using Business.Responses.CorporateCustomer;
using DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CorporateCustomerManager : ICorporateCustomerService
    {
        private readonly ICorporateCustomerDal _corporateCustomerDal;
        private readonly IMapper _mapper;
        private readonly CorporateCustomerBusinessRules _corporateCustomerBusinessRules;

        public CorporateCustomerManager(ICorporateCustomerDal corporateCustomerDal, IMapper mapper, CorporateCustomerBusinessRules corporateCustomerBusinessRules)
        {
            _corporateCustomerDal = corporateCustomerDal;
            _mapper = mapper;
            _corporateCustomerBusinessRules = corporateCustomerBusinessRules;
        }

        public AddCorporateCustomerResponse Add(AddCorporateCustomerRequest request)
        {
            CorporateCustomer corporateCustomerToAdd = _mapper.Map<CorporateCustomer>(request);
            _corporateCustomerDal.Add(corporateCustomerToAdd);
            AddCorporateCustomerResponse response = _mapper.Map<AddCorporateCustomerResponse>(request);
            return response;
        }

        public GetCorporateCustomerByIdResponse GetById(GetCorporateCustomerByIdRequest request)
        {
            CorporateCustomer corporateCustomer = _mapper.Map<CorporateCustomer>(request);
            _corporateCustomerDal.Add(corporateCustomer);

            var response = _mapper.Map<GetCorporateCustomerByIdResponse>(corporateCustomer);
            return response;
        }
        public GetCorporateCustomerListResponse GetList(GetCorporateCustomerListRequest request)
        {


            IList<CorporateCustomer> corporateCustomerList = _corporateCustomerDal.GetList(
                predicate: corporateCustomer =>
                    (request.FilterByCorporateCustomerId == null || corporateCustomer.Id== request.FilterByCorporateCustomerId)


            );


            var response = _mapper.Map<GetCorporateCustomerListResponse>(corporateCustomerList);

            return response;
        }
    }
}
