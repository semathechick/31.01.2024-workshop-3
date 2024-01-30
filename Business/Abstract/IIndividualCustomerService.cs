
using Business.Requests.Customers;
using Business.Requests.IndividualCustomer;
using Business.Responses.IndividualCustomer;
using Business.Responses.Model;


namespace Business.Abstract
{
    public interface IIndividualCustomerService
    {
        public AddIndividualCustomerResponse Add(AddIndividualCustomerRequest request);
        public GetIndividualCustomerListResponse GetList(GetIndividualCustomerListRequest request);
        public GetIndividualCustomerByIdResponse GetById(GetIndividualCustomerByIdRequest request);
    }
}
