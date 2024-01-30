

using AutoMapper;
using Business.BusinessRules;
using Business.Requests.IndividualCustomer;
using Business.Requests.Model;
using Business.Responses.IndividualCustomer;
using Business.Responses.Model;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class IndividualCustomerManager
    {
        IIndividualCustomerDal _individualCustomerDal;
        IndividualCustomerBusinessRules _individualCustomerBusinessRules;
        IMapper _mapper;

        public IndividualCustomerManager(IIndividualCustomerDal iIndividualCustomerDal, IndividualCustomerBusinessRules individualCustomerBusinessRules, IMapper mapper)
        {
            iIndividualCustomerDal = _individualCustomerDal;
            _individualCustomerBusinessRules = individualCustomerBusinessRules;
            _mapper = mapper;
        }

        public AddIndividualCustomerResponse Add(AddIndividualCustomerRequest request)
        {
            _individualCustomerBusinessRules.CheckIfCustomerNameIsExists($"{request.FirstName} {request.LastName}");

            IndividualCustomer individualCustomerToAdd = _mapper.Map<IndividualCustomer>(request);
            _individualCustomerDal.Add(individualCustomerToAdd);
            AddIndividualCustomerResponse response = _mapper.Map<AddIndividualCustomerResponse>(request);
            return response;
        }
        public GetIndividualCustomerByIdResponse GetById(GetIndividualCustomerByIdRequest request)
        {
            IndividualCustomer individualCustomer = _individualCustomerDal.Get(predicate: individual => individual.Id == request.UserId);

            // Check if the individual exists by full name
            _individualCustomerBusinessRules.CheckIfCustomerNameIsExists($"{individualCustomer.FirstName} {individualCustomer.LastName}");

            var response = _mapper.Map<GetIndividualCustomerByIdResponse>(individualCustomer);
            return response;
        }


    }
}
