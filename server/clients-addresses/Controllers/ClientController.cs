using clients_addresses.Data.Models;
using clients_addresses.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace clients_addresses.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;

        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpGet(Name = "GetClients")]
        [ProducesResponseType(typeof(IEnumerable<Client>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Client>>> GetClients()
        {
            List<Client> clients = (List<Client>)await _clientRepository.GetAllClientsAsync();
            return Ok(clients);
        }

        [HttpGet("{id}", Name = "GetClient")]
        [ProducesResponseType(typeof(Client), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Client>> GetClient(int id)
        {
            Client client = await _clientRepository.GetClientById(id);
            return Ok(client);
        }

        [HttpGet("address/{id}", Name = "GetClientAddresses")]
        [ProducesResponseType(typeof(IEnumerable<ClientAddress>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<ClientAddress>>> GetClientAddresses(int id)
        {
            List<ClientAddress> clientAddresses = (List<ClientAddress>)await _clientRepository.GetClientAddressesAsync(id);
            return Ok(clientAddresses);
        }
    }
}
