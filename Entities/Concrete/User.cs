using Core.Entities;

namespace Entities.Concrete
{
    public class User : Entity<int>
    {
        public User(
            string firstName,
            string lastName,
            string email,
            string password,
            string nationalIdentity
            )
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            NationalIdentity = nationalIdentity;
        }
      

        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public  string Email { get; set; }   
        public  string Password { get; set; }
        public string NationalIdentity { get; set; }

        public Customer Customers { get; set; }
    }
}
