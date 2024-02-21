using DockerCalculator;
using Microsoft.EntityFrameworkCore;

public class CalculatorDbContext : DbContext
{
    public DbSet<DataLog> DataLogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=DockerCalculator;User Id=sa;Password=123456;TrustServerCertificate=true");
    }

}