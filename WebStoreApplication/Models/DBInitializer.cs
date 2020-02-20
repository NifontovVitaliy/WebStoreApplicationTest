using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreApplication.Models
{
    public class DBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)//TODO: Async?
        {
            WebStoreDbContext dbContext =
                applicationBuilder.ApplicationServices.GetRequiredService<WebStoreDbContext>();
            if (!dbContext.Companies.Any())
            {
                dbContext.Companies.AddRange();//TODO: Add companies
            }
            if (!dbContext.Phones.Any())
            {
                dbContext.Phones.AddRange();//TODO: Add phones
            }
            dbContext.SaveChanges();
        }
    }
}
