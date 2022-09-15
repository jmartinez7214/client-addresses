using clients_addresses.Data.Models;

namespace clients_addresses.Data.Repositories
{
    public interface IClientRepository
    {
        Task<IReadOnlyList<Client>> GetAllClientsAsync();
        Task<Client> GetClientById(int id);
        Task<IReadOnlyList<ClientAddress>> GetClientAddressesAsync(int clientId);
    }
}
