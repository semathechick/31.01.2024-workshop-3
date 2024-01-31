namespace Business.Responses.IndividualCustomer
{
    public class UpdateIndividualCustomerResponse
    {
        public int CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateTime { get; set; }
    }
}