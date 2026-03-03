using Spectre.Console;
using System.Threading;

namespace Flashcards.Menus
{
    //Rename this class to something more appropriate.
    public class CreationMenu
    {
        public static void StackCreationMenu()
        {
            Console.Clear();

            AnsiConsole.MarkupLine("[slowblink][purple]Welcome to the Subject creator.[/][/]");
            Console.WriteLine();
            AnsiConsole.MarkupLine("[Green]1. Add a new flashcard to an existing subject.[/]");
            AnsiConsole.MarkupLine("[Yellow]2. Create a new subject.[/]");
            AnsiConsole.MarkupLine("[Blue]3. View existing subjects[/]");
            AnsiConsole.MarkupLine("[Maroon]4. Return to the main menu.[/]");
            // TODO Double check the spinner funcion. 

            string temp = Console.ReadLine();

            switch (temp)
            {
                case "1":
                    Card_Ops.FlashcardCreation.CardCreator();
                    break;

                case "2":
                    Stack_Ops.StackCreation.CreateStack();
                    break;

                case "3":
                    Database_Helpers.ViewStacks.DisplayStacks();
                    break;

                case "4":
                    MainMenu.HomeScreen();
                    break;

                default:
                    AnsiConsole.MarkupLine(@"[rapidblink][maroon]Invalid Response![/][/]
                                                Please choose an option [bold][underline]listed above[/][/]. Thank you");

                    AnsiConsole.Status()
                        .Start("Returning to the stacks menu...", ctx =>
                        {
                            ctx.Spinner(Spinner.Known.Aesthetic);
                            Thread.Sleep(3000);
                        });
                    StackCreationMenu();
                    break;
            }



        }
        
    }
}
