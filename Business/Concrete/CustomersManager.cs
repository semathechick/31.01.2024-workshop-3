

using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Customers;
using Business.Requests.Model;
using Business.Responses.Customers;
using Business.Responses.Model;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomersManager: ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly IMapper _mapper;
        private readonly CustomersBusinessRules _customerBusinessRules;

        public CustomersManager(ICustomerDal customerDal, IMapper mapper, CustomersBusinessRules customerBusinessRules)
        {
            _customerDal = customerDal;
            _mapper = mapper;
            _customerBusinessRules = customerBusinessRules;
        }

        public AddCustomerResponse Add(AddCustomerRequest request)
        {
            //var customersToAdd = _mapper.Map<Customer>(request);
            //_customerDal.Add(customersToAdd);
            //AddCustomerResponse response = _mapper.Map<AddCustomerResponse>(request);
            //return response;
            var customerToAdd = _mapper.Map<Customer>(request);

            Customer addedCustomer = _customerDal.Add(customerToAdd);

            var response = _mapper.Map<AddCustomerResponse>(addedCustomer);
            return response;
        }

        public GetCustomerByIdResponse GetById(GetCustomerByIdRequest request)
        {
            Customer customers = _mapper.Map<Customer>(request);
                _customerDal.Add(customers);

            var response = _mapper.Map<GetCustomerByIdResponse>(customers);
            return response;
        }
        public GetCustomerListResponse GetList(GetCustomerListRequest request)
        {


            IList<Customer> customerList = _customerDal.GetList(
                predicate: customers =>
                    (request.FilterByCustomerId == null || customers.UserId == request.FilterByCustomerId)


            );

          
            var response = _mapper.Map<GetCustomerListResponse>(customerList);

            return response;
        }
    }
}
