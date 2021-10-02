using Equipe2_PneuStore.Data;
using Equipe2_PneuStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Equipe2_PneuStore.Services
{
    public class AddressService : IAddressService
    {
        Context _context;
        //construtor
        public AddressService(Context context)
        {
            _context = context;
        }

        public List<Address> All()
        {
            return _context.Address.ToList();
        }

        public bool Create(Address address)
        {
            try
            {
                _context.Add(address);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Address Get(int? id)
        {
            return _context.Address.FirstOrDefault(a => a.Id == id);
        }

        public bool Update(Address address)
        {
            try
            {
                if (!_context.Address.Any(a => a.Id == address.Id))
                    throw new Exception("Endereço não existente!");

                _context.Update(address);
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
