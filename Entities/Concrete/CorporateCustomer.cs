

using Core.Entities;

namespace Entities.Concrete
{
    public class CorporateCustomer : Entity<int>
    {
        public CorporateCustomer(int customerId, string companyName, string taxNo)
        {
            CustomerId = customerId;
            CompanyName = companyName;
            TaxNo = taxNo;
        }

        public int  CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
        

        public Customer? Customers { get; set; } = null;
        
    }
}
