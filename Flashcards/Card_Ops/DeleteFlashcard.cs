using Microsoft.Data.SqlClient;

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

            //left off here
        }
    }
}
