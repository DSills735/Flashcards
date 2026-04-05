using Dapper;
using Microsoft.Data.SqlClient;
using Spectre.Console;

namespace Flashcards.Card_Ops
{
    internal class DeleteFlashcard
    {
        static string? connectionString = Database_Helpers.ConnectionString.ConnString();

        internal static void DeleteSingleFlashcard()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            Console.WriteLine("What flashcard would you like to delete? (Enter the ID)");
            Console.WriteLine();

            Database_Helpers.ViewFlashcards.FlashcardsToTable();
            bool exists = false;
            
            string resp = Console.ReadLine()!;

            while (!exists || resp == null)
            {
                int count = connection.ExecuteScalar<int>(SQL_Helpers.SqlHelper.SearchFlashcardsByID(), new { FlashcardID = resp });

                if (count == 0)
                {

                    AnsiConsole.MarkupLine(@"[rapidblink][maroon]ERROR!![/][/][red] This stack was not found.[/] Please ensure the ID you are entering is reflected on the table above.");
                    resp = Console.ReadLine()!;
                }
                else
                {
                    exists = true;
                }
            }

            AnsiConsole.MarkupLine("[rapidblink][maroon] Are you sure you want to delete this flashcard?[/][/] Y / N");

            string tmp = Console.ReadLine()!.Trim().ToLower();

            if (tmp == "y")
            {
                connection.Execute(SQL_Helpers.SqlHelper.DeleteFlashcard(), new { FlashcardID = resp });
                AnsiConsole.Status()
                .Start("Deleting flaschard and returning you to the delete menu. ", ctx =>
                {

                    ctx.Spinner(Spinner.Known.Aesthetic);
                    Thread.Sleep(3000);
                });
                Menus.DeleteMenu.DeleteMenus();
            }
            else
            {
                AnsiConsole.Status()
                .Start("Stopping flaschard deletion and returning you to the Delete menu. ", ctx =>
                {

                    ctx.Spinner(Spinner.Known.Aesthetic);
                    Thread.Sleep(3000);
                });

                Menus.DeleteMenu.DeleteMenus();
            }
        }
    }
}
