namespace Sahara.Api.Modules.Customers.Domain
{
    public class Customer
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string DisplayName { get; set; } = string.Empty;
        public List<CustomerAddress> Addresses { get; set; } = [];
    }
}
