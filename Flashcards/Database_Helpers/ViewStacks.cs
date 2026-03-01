using Flashcards.SQL_Helpers;
using Microsoft.Data.SqlClient;
using Spectre.Console;
using Microsoft.Extensions.Configuration;
using Dapper;


namespace Flashcards.Database_Helpers
{
    internal class ViewStacks
    {
        static string? connectionString = Program.Program.config.GetConnectionString("DefaultConnection");

        
        public static void DisplayStacks()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            Console.Clear();
            var stacks = connection.Query(SqlHelper.ViewStacks()).ToList();


        var table = new Table()
                .RoundedBorder()
                .BorderColor(Color.Blue);
            table.AddColumn("[red]Stack ID[/]");
            table.AddColumn("[green]Subject[/]");

            foreach (var stack in stacks)
            {
                table.AddRow($"[red]{stack.StackID}[/]", $"[green]{stack.Subject}[/]");
            }

            AnsiConsole.Write(table);

            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();

            Menus.CardCreation.CreationMenu();
        }

        }
    }


