using ApiPneuStore.Models;
using System.Collections.Generic;

namespace Equipe2_PneuStore.Services
{
    public interface ITyreService
    {
        List<Tyre> All();

        Tyre Get(int? id);

        bool Create(Tyre tyre);

        bool Update(Tyre tyre);
    }
}
