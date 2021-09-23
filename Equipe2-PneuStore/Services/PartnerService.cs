using ApiPneuStore.Models;
using Equipe2_PneuStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Equipe2_PneuStore.Services
{
    public class PartnerService : IPartnerService
    {
        Context _context;
        //construtor
        public PartnerService(Context context)
        {
            _context = context;
        }

        public List<Partner> All()
        {
            return _context.Partner.ToList();
        }

        public bool Create(Partner partner)
        {
            try
            {
                _context.Add(partner);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Partner Get(int? id)
        {
            return _context.Partner.FirstOrDefault(p => p.Id == id);
        }

        public bool Update(Partner partner)
        {
            try
            {
                if (!_context.Partner.Any(p => p.Id == partner.Id))
                    throw new Exception("Item não encontrado");

                _context.Update(partner);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int? id)
        {
            try
            {
                _context.Remove(this.Get(id));
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
