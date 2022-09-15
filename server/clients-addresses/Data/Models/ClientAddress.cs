namespace clients_addresses.Data.Models
{
    public class ClientAddress
    {
        public int Id { get; set; }
        public string? Address { get; set; }
        public int ClientId { get; set; }

        public virtual Client? Client { get; set; }
    }
}
