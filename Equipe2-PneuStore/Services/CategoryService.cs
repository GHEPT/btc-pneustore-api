using ApiPneuStore.Models;
using Equipe2_PneuStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return _context./**/.ToList();
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
            return _context./**/.FirstOrDefault(p => p.id == id);
        }
    }
}
