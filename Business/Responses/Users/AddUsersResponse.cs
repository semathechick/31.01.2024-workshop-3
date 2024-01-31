namespace Business
{
    public class AddUsersResponse
    {
        public AddUsersResponse(int ıd, string firstName, string lastName, DateTime createdAt)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            CreatedAt = createdAt;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }

      
    }
}