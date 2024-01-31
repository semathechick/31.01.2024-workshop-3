

using AutoMapper;
using Business.BusinessRules;
using Business.Requests.IndividualCustomer;

using Business.Responses.IndividualCustomer;
using DataAccess.Abstract;

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
           

            IndividualCustomer individualCustomerToAdd = _mapper.Map<IndividualCustomer>(request);
            _individualCustomerDal.Add(individualCustomerToAdd);
            AddIndividualCustomerResponse response = _mapper.Map<AddIndividualCustomerResponse>(request);
            return response;
        }
        public GetIndividualCustomerByIdResponse GetById(GetIndividualCustomerByIdRequest request)
        {
            IndividualCustomer individualCustomer = _individualCustomerDal.Get(predicate: individual => individual.Id == request.CustomerId);

            var response = _mapper.Map<GetIndividualCustomerByIdResponse>(individualCustomer);
            return response;
        }
        public UpdateIndividualCustomerResponse Update(UpdateIndividualCustomerRequest request)
        {
            IndividualCustomer? individualToUpdate = _individualCustomerDal.Get(predicate: individual => individual.CustomerId== request.CustomerId); 
          
            _individualCustomerBusinessRules.CheckIfIndividualCustomerExists(individualToUpdate);

           
            individualToUpdate = _mapper.Map(request, individualToUpdate); 
            IndividualCustomer updatedIndividual = _individualCustomerDal.Update(individualToUpdate!);

            var response = _mapper.Map<UpdateIndividualCustomerResponse>(
                updatedIndividual 
            );
            return response;
        }


    }
}
