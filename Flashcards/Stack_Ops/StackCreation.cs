using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Spectre.Console;

namespace Flashcards.Stack_Ops
{//TODO Refactor this.
    internal class StackCreation
    {
        //TODO make sure the connection string is being pulled correctly. IF so, refactor to use the same method for the rest of the program.
        //static string? connectionString = Program.Program.config.GetConnectionString("DefaultConnection");
        static string? connectionString = Database_Helpers.ConnectionString.ConnString();
        public static void CreateStack()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            Console.Clear();
            //TODO investigate why slowblink isnt displaying appropriately
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
                    //TODO make sure the database is queried correctly. 
                    AnsiConsole.MarkupLine(@"[rapidblink][maroon]ERROR!![/][/][red] You cannot create a new subject with an existing name. Please enter another name.");
                    name = Console.ReadLine();
                }

            }
            
            //TODO - Spinner. -- Need to test. 
            AnsiConsole.Status()
                .Start("Creating stack...", ctx =>
                {
                    connection.Execute(SQL_Helpers.SqlHelper.AddToStacks(), new { Subject = name });
                    ctx.Spinner(Spinner.Known.Aesthetic);
                    Thread.Sleep(3000);
                });


        }
        
    }
}
