using Microsoft.Data.SqlClient;
using Spectre.Console;
using Dapper;
using Flashcards.Mapping;

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

            //TODO refactor the below into its own class? I think it would reduce boilerplate code 

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

                var subject = connection.Query<Flashcards.Entities.Flashcard>(SQL_Helpers.SqlHelper.ReturnEntireStackWithStackID(), new {StackID = resp});

                int qNum = 1;
                int score = 0;
                //TODO Logic finally figured out.., Need to finish this section and find a way to possibly randomize the cards?
                //maybe needs to be done in SQL
                foreach (var stack in subject)
                {
                    var dto = stack.ToDto();

                    Console.WriteLine($"Question {qNum}: {dto.Question}");
                    Console.WriteLine();
                    Console.WriteLine("When you are ready to see the answer, press any key.");
                    Console.ReadKey();
                    Console.WriteLine(dto.Answer);



                }

            }
        }
    }
}
