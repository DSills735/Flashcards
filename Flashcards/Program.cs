using Microsoft.Data.Sql;
using Microsoft.Extensions.Configuration;

public class Program
{
    internal static IConfiguration config = new ConfigurationBuilder()
          .AddJsonFile("appsettings.json")
          .Build();

    static string? connectionString = config.GetConnectionString("DefaultConnection");



}
