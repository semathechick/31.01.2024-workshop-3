using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess
{
    public interface ICorporateCustomerDal : IEntityRepository<CorporateCustomer, int>
    {
       
    }
}