

using Core.Entities;

namespace Entities.Concrete
{
    public class CorporateCustomer : Entity<int>
    {
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
        public CorporateCustomer( string companyName, string taxNo)
        {
            
            CompanyName = companyName;
            TaxNo = taxNo;
        }

        public Customer? Customers { get; set; } = null;
        
    }
}
