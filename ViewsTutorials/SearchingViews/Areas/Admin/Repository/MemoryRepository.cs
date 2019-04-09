using System.Collections.Generic;
using ViewsProject.Areas.Admin.Models;

namespace ViewsProject.Areas.Admin.Repository
{
    public class MemoryRepository
    {
        private readonly IDictionary<int, Client> _clients = new Dictionary<int, Client>();

        public MemoryRepository()
        {
            AddClient(new Client{ClientName = "Paweł"});
            AddClient(new Client{ClientName = "Krzysztof"});
        }
        
        public Client this[int id] => _clients[id];

        public IEnumerable<Client> Clients => _clients.Values;

        public Client AddClient(Client client)
        {
            var index = _clients.Count;
            client.ClientId = index;

            _clients[index] = client;

            return client;
        }
    }
}