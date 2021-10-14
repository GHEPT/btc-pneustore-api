using Equipe2_PneuStore.Models;
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
                if (!context.Tyre.Any())
                {
                    for (var i = 1; i <= 10; i++)
                    {
                        context.Tyre.Add(new Tyre
                        {
                            Brand = $"Marca {i}",
                            Model = $"Modelo {i}",
                            Price = 99.99,
                            Description = $"Descrição {i}",
                        });
                    }
                }
                
                if (!context.Category.Any())
                {
                    context.Category.Add(new Category { Type = "Carro de Passeio" });
                    context.Category.Add(new Category { Type = "Caminhão/Ônibus" });
                    context.Category.Add(new Category { Type = "Motocicleta" });
                }

                if (!context.Partner.Any())
                {
                    for (var i = 1; i <= 3; i++)
                    {
                        context.Partner.Add(new Partner
                        {
                            Name = $"Parceiro {i}",
                            PhoneNumber = $"({i}{i}) {i}{i}{i}{i}{i} - {i}{i}{i}{i}",
                            Address1 = $"Endereço {i}",
                            ZipCode = $"{i}{i}{i}{i}{i} - {i}{i}{i}",
                            City = $"Cidade {i}",
                            State = $"Estado {i}",
                            Note = 5
                        });
                    }
                }
                               
                context.SaveChanges();
            }
        }
    }
}
