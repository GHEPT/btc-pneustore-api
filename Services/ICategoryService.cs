using Equipe2_PneuStore.Models;
using System.Collections.Generic;

namespace Equipe2_PneuStore.Services
{
    public interface ICategoryService
    {
        List<Category> All();

        Category Get(int? id);

        bool Create(Category category);
    }
}
