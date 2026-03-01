using Dapper;
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
            //the slow blink isnt displaying properly
            AnsiConsole.WriteLine("[slowblink]Welcome to the create a stack area.[/]");
            AnsiConsole.WriteLine();
            AnsiConsole.WriteLine("Please enter a unique name for the subject you wish to create.");

            string name = Console.ReadLine();

            bool exists = false;


            while (!exists)
            {
                int count = connection.Execute(SQL_Helpers.SqlHelper.SearchStacks(), new { Subject = name });

                if (count > 0)
                {
                    //make sure the database is queried correctly. 
                    AnsiConsole.MarkupLine(@"[rapidblink][maroon]ERROR!![/][/][red] You cannot create a new subject with an existing name. Please enter another name.");
                    name = Console.ReadLine();
                }

            }

            connection.Execute(SQL_Helpers.SqlHelper.AddToStacks(), new { Subject = name });

            //need to either scrap the spinner, or find a good way to implement it.
            ShowSpinner();

            
        }
        public static async Task ShowSpinner()
        {
            await AnsiConsole.Status()
                .Spinner(Spinner.Known.Aesthetic)
                .StartAsync("Creating the subject...", async ctx =>
                {
                    await Task.Delay(1000);
                });
                
        }
        
    }
}
