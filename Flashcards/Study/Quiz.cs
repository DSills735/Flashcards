using Microsoft.Data.SqlClient;
using Spectre.Console;
using Dapper;

namespace Flashcards.Study
{
    internal class Quiz
    {
        static string? connectionString = Database_Helpers.ConnectionString.ConnString();
        internal static void SingleSubjectQuiz()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            Console.WriteLine("What subject would you like quizzed on?");

            Database_Helpers.ViewStacks.DisplayStacksForUpdate();

            string resp = Console.ReadLine();

            bool exists = false;

            //TODO refactor the below into its own class?

            while (!exists)
            {
                int count = connection.ExecuteScalar<int>(SQL_Helpers.SqlHelper.SearchStacksByID(), new { StackID = resp });

                if (count == 0)
                {

                    AnsiConsole.MarkupLine(@"[rapidblink][maroon]ERROR!![/][/][red] This stack was not found.[/] Please ensure the ID you are entering is reflected on the table above.");
                    resp = Console.ReadLine();
                }
                else
                {
                    exists = true;
                }
            }
        }
    }
}
