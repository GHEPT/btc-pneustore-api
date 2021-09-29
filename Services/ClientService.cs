using Equipe2_PneuStore.Data;
using Equipe2_PneuStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Equipe2_PneuStore.Services
{
    public class ClientService : IClientService
    {
        Context _context;
        //construtor
        public ClientService(Context context)
        {
            _context = context;
        }

        public List<Client> All()
        {
            return _context.Client.ToList();
        }

        public Client Get(int? id)
        {
            return _context.Client.FirstOrDefault(c => c.Id == id);
        }
        
        public bool Create(Client client)
        {
            try
            {
                _context.Add(client);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Client client)
        {
            try
            {
                if (!_context.Client.Any(c => c.Id == client.Id))
                    throw new Exception("Cliente não existente!");

                _context.Update(client);
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
