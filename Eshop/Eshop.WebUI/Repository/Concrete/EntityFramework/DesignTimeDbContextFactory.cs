using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Eshop.WebUI.Repository.Concrete.EntityFramework
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EshopContext>
    {
        public EshopContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<EshopContext>();
            var connectionstring = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionstring);
            return new EshopContext(builder.Options);

        }
    }
}
