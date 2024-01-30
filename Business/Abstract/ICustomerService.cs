using Business.Requests.Customers;
using Business.Responses.Customers;


namespace Business.Abstract
{
    public interface ICustomerService
    {
        public AddCustomerResponse Add(AddCustomerRequest request);
        public GetCustomerListResponse GetList(GetCustomerListRequest request);
        public GetCustomerByIdResponse GetById(GetCustomerByIdRequest request);
    }
}
