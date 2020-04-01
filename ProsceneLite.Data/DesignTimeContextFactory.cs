using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ProsceneLite.Data
{
    public class DesignTimeContextFactory : IDesignTimeDbContextFactory<ProsceneContext>
    {
        public ProsceneContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<ProsceneContext>();

            var connectionStrings = configuration.GetConnectionString("DB_Mysql");
            builder.UseMySQL(connectionStrings);
            
            
            
            return new ProsceneContext(builder.Options);
        }

    }
}
