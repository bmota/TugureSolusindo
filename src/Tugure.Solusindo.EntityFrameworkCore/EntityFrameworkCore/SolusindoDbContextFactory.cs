using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Tugure.Solusindo.Configuration;
using Tugure.Solusindo.Web;

namespace Tugure.Solusindo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SolusindoDbContextFactory : IDesignTimeDbContextFactory<SolusindoDbContext>
    {
        public SolusindoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SolusindoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SolusindoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SolusindoConsts.ConnectionStringName));

            return new SolusindoDbContext(builder.Options);
        }
    }
}