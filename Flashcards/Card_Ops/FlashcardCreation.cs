using Dapper;
using Microsoft.Data.SqlClient;
using Spectre.Console;


namespace Flashcards.Card_Ops
{
    internal class FlashcardCreation
    {

        static string? connectionString = Database_Helpers.ConnectionString.ConnString();
        
        internal static void CardCreator()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            bool reply = false;
            Console.WriteLine("Hello. Please choose the ID of a subject you would like to add this card to.");

            Database_Helpers.ViewStacks.DisplayStacksForUpdate();

            Console.WriteLine();

            //TODO refactor the below code to streamline

            string subj = Console.ReadLine();
            int stackID = Convert.ToInt32(subj);
             
            int subject = connection.Execute(SQL_Helpers.SqlHelper.SearchForSubjectID(), new { StackID = subj });

            AnsiConsole.Status()
                .Start("Searching for subject...", ctx =>
                 {
                     //TODO validation is not working as i expected. 
                     reply = Validation.DbValidation.ValidateSearchByStackID(subject);
                     ctx.Spinner(Spinner.Known.Aesthetic);
                     Thread.Sleep(3000);


                 });
            if (!reply)
            {
                CardCreator();
            }
            
        }

    }
}


