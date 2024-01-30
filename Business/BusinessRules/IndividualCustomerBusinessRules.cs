using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
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
        public void CheckIfCustomerNameIsExists(string individualName)
        {
            bool isExists = _individualCustomerDal.Get(individual => $"{individual.FirstName}  {individual.LastName}"== individualName) is not null ;
            if(!isExists)
            {
                throw new BusinessException("User can not be found.");
            }
        }

        
    }
}
