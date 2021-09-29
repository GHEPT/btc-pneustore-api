using Equipe2_PneuStore.Models;
using System.Collections.Generic;

namespace Equipe2_PneuStore.Services
{
    public interface IAddressService
    {
        List<Address> All();

        Address Get(int? id);

        bool Create(Address address);

        bool Update(Address address);

        bool Delete(int? id);
    }
}
