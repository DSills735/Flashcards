

using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Spectre.Console;

namespace Flashcards.Stack_Ops
{
    internal class StackCreation
    {
        static string? connectionString = Program.Program.config.GetConnectionString("DefaultConnection");

        public static void CreateStack()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            Console.Clear();

            AnsiConsole.WriteLine();
        }
    }
}
