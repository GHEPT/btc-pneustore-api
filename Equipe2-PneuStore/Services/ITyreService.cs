using ApiPneuStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
