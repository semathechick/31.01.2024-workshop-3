using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


namespace Business.BusinessRules
{
    public class IndividualCustomerBusinessRules
        
    {
        
        private readonly IIndividualCustomerDal _individualCustomerDal;
        public IndividualCustomerBusinessRules(IIndividualCustomerDal individualCustomerDal) 
        {
            _individualCustomerDal = individualCustomerDal;
            
        }
        public void CheckIfIndividualCustomerExists(IndividualCustomer? individualCustomer)
        {
            if (individualCustomer is null)
                throw new NotFoundException("Customer not found.");
        }


    }
}
