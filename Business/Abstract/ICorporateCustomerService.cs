
using Business.Requests.CorporateCustomer;
using Business.Responses.CorporateCustomer;

namespace Business.Abstract
{
    public interface ICorporateCustomerService
    {
        public AddCorporateCustomerResponse Add(AddCorporateCustomerRequest request);
        public GetCorporateCustomerListResponse GetList(GetCorporateCustomerListRequest request);
        public GetCorporateCustomerByIdResponse GetById(GetCorporateCustomerByIdRequest request);
    }
}

