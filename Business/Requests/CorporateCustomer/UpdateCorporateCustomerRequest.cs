

namespace Business.Requests.CorporateCustomer
{
    public class UpdateCorporateCustomerRequest
    {
       public int CustomerId { get; set; }
        public string? CompanyName { get; set; }
        public string? TaxNo { get; set; }
    }
}
