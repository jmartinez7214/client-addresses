namespace clients_addresses.Data.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public virtual ICollection<ClientAddress>? ClientAddresses { get; set; }
    }
}
