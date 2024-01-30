

using Core.Entities;

namespace Entities.Concrete
{
    public class Customer : Entity<int>
    {
        public int UserId { get; set; }

        public Customer(int userId)
        {
            UserId = userId;
        }
        public Customer (){}
       public User Users { get; set; } 
        public IndividualCustomer individualCustomers { get; set; }

        public CorporateCustomer corporateCustomers { get; set;}

    }
}
