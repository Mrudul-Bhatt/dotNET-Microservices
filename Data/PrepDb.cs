using System;
using System.Linq;
using dotNET_Microservices.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace dotNET_Microservices.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder applicationBuilder)
        {
            using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
            SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
        }

        private static void SeedData(AppDbContext appDbContext)
        {
            if (!appDbContext.Platforms.Any())
            {
                Console.WriteLine("---> Seeding Data...");

                appDbContext.Platforms.AddRange(
                    new Platform { Name = "DotNet", Publisher = "MSFT", Cost = "Free" },
                    new Platform { Name = "SQL Server", Publisher = "MSFT", Cost = "Free" },
                    new Platform { Name = "Kubernetes", Publisher = "CNCF", Cost = "Free" }
                );

                appDbContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("---> We already have data");
            }
        }
    }
}