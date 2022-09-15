using clients_addresses.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace clients_addresses.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        protected readonly CompanyXDbContext _context;

        public ClientRepository(CompanyXDbContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Client>> GetAllClientsAsync()
        {
            return await _context!.Clients!.ToListAsync();
        }

        public async Task<IReadOnlyList<ClientAddress>> GetClientAddressesAsync(int clientId)
        {
            return await _context!.ClientAddresses!.Where(x => x.ClientId == clientId).ToListAsync();
        }

        public async Task<Client> GetClientById(int id)
        {
            return await _context!.Clients!.FindAsync(id);
        }
    }
}
