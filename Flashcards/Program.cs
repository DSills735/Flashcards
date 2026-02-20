using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;
public class Program
{
    internal static IConfiguration config = new ConfigurationBuilder()
          .AddJsonFile("appsettings.json")
          .Build();

    static string? connectionString = config.GetConnectionString("DefaultConnection");

    static void Main(string[] args)
    {
        SqlConnection connection = new SqlConnection(connectionString);

        connection.Open();

    }

}
