using Equipe2_PneuStore.Models;
using System.Collections.Generic;

namespace Equipe2_PneuStore.Services
{
    public interface IClientService
    {
        List<Client> All();

        Client Get(int? id);

        bool Create(Client client);

        bool Update(Client client);

        bool Delete(int? id);
    }
}
