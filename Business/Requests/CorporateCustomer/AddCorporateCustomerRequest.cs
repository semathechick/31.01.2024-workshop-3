namespace Business.Requests.CorporateCustomer
{
    public class AddCorporateCustomerRequest
    {
        public int CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? TaxNo { get; set; }

    }
}