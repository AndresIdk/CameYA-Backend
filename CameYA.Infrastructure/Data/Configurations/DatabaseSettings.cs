using Microsoft.Extensions.Configuration;

namespace CameYA.Infrastructure.Data.Configurations
{
    public class DatabaseSettings
    {
        private readonly string? connectionString = string.Empty;
        public DatabaseSettings()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json")).Build();

            connectionString = builder.GetSection("ConnectionStrings:connectionMaster").Value;
        }

        public string? CadSQL()
        {
            return connectionString;
        }
    }
}
