using ApiPneuStore.Models;
using System.Collections.Generic;

namespace Equipe2_PneuStore.Services
{
    public interface IPartnerService
    {
        List<Partner> All();

        Partner Get(int? id);

        bool Create(Partner partner);

        bool Update(Partner partner);

        bool Delete(int? id);
    }
}
