using ApiPneuStore.Models;
using Equipe2_PneuStore.Data;
using System.Collections.Generic;
using System.Linq;

namespace Equipe2_PneuStore.Services
{
    public class CategoryService : ICategoryService
    {
        Context _context;
        //construtor
        public CategoryService(Context context)
        {
            _context = context;
        }

        public List<Category> All()
        {
            return _context.Category.ToList();
        }

        public bool Create(Category category)
        {
            try
            {
                _context.Add(category);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Category Get(int? id)
        {
            return _context.Category.FirstOrDefault(p => p.Id == id);
        }
    }
}
