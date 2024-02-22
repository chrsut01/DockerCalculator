using DockerCalculator;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
public class CalculatorDbContext : DbContext
{
    public DbSet<DataLog> DataLogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var configuration = configBuilder.Build();
        
            string connectionString = configuration.GetConnectionString("CalculatorDbContext");

            optionsBuilder.UseSqlServer(connectionString);
    }
}