using ApiPneuStore.Models;
using Equipe2_PneuStore.Data;
using System;
using System.Collections.Generic;
<<<<<<< Updated upstream
using System.Linq;
=======
>>>>>>> Stashed changes

namespace Equipe2_PneuStore.Services
{
    public class TyreService : ITyreService
    {
        Context _context;
        //construtor
        public TyreService(Context context)
        {
            _context = context;
        }

        public List<Tyre> All()
        {
            return _context./*Tyre*/.ToList();
        }

        public bool Create(Tyre tyre)
        {
            try
            {
                _context.Add(tyre);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Tyre Get(int? id)
        {
            return _context./*Tyre*/.FirstOrDefault(p => p.id == id);
        }

        public bool Update(Tyre tyre)
        {
            try
            {
                if (!_context./*Tyre*/.Any(p => p.id == tyre.Id))
                    throw new Exception("Item não encontrado");

                _context.Update(tyre);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
