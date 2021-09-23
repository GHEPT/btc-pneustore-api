using ApiPneuStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Equipe2_PneuStore.Data
{
    public class SeedDatabase
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Context(
                serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                if (context.Tyre.Any())
                {
                    return;
                }

                for(var i=1; i <= 10; i++)
                {
                    context.Tyre.Add(new Tyre
                    {
                        Brand = $"Marca {i}",
                        Model = $"Modelo {i}",
                        Price = 99.99,
                        Description = $"Descrição {i}",                       
                    });
                    context.Partner.Add(new Partner
                    {
                        Name = $"Parceiro {i}",
                        PhoneNumber = $"({i}{i}) {i}{i}{i}{i} - {i}{i}{i}{i}",
                        Address = $"Endereço {i}"
                    });
                }        
                
                context.SaveChanges();
            }
        }
    }
}
