using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Tugure.Solusindo.EntityFrameworkCore
{
    public static class SolusindoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SolusindoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SolusindoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}