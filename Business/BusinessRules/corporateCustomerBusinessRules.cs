using Core.CrossCuttingConcerns.Exceptions;
using DataAccess;
using Entities.Concrete;

namespace Business
{
    public class CorporateCustomerBusinessRules
    {
        private readonly ICorporateCustomerDal _corporateCustomerDal;
        public void CheckIfCorporateCustomerNameExists(string name )
        {
            bool isNameExists = _corporateCustomerDal.Get(m => m.CompanyName== name) != null;
            if (isNameExists)
                throw new BusinessException("Company already exists.");
        }

        public void CheckIfCompanyExists(CorporateCustomer? corporateCustomer)
        {
            if (corporateCustomer is null)
                throw new NotFoundException("Company not found.");
        }
    }
}