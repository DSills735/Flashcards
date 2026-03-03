
using Spectre.Console;

namespace Flashcards.Validation
{
    internal class DbValidation
    {
        //TODO ref FlashcardCreaton CardCreator
        public static bool ValidateSearchByStackID(int queryResp)
        {
            if (queryResp == 0)
            {
                AnsiConsole.MarkupLine("[maroon][slowblink]ERROR!![/][/] ID is not found. Please try again, choosing an ID from the table.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
