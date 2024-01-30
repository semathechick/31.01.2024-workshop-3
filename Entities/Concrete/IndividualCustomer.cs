

using Core.Entities;

namespace Entities.Concrete
{
    public class IndividualCustomer : Entity<int>
    {
        public int CustomerId { get; set; }
        public  string? FirstName { get; set; }
        public  string? LastName { get; set; }
        public Customer? Customers { get; set; } = null;
        
    }
}
