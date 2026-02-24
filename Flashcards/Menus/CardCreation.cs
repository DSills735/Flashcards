using Spectre.Console;

namespace Flashcards.Menus
{
    public class CardCreation
    {
        public static void CreationMenu()
        {
            Console.Clear();

            AnsiConsole.MarkupLine("[slowblink][purple]Welcome to the flashcard creator.[/][/]");
            Console.WriteLine();
            AnsiConsole.MarkupLine("[Green]1. Choose from an existing stack.[/]");
            AnsiConsole.MarkupLine("[Yellow]2. Create a new stack.[/]");
            AnsiConsole.MarkupLine("[Blue]3. View existing stacks[/]");
            AnsiConsole.MarkupLine("[MAroon]4. Return to the main menu.[/]");

            string temp = Console.ReadLine();

            switch (temp)
            {
                case "1":
                    break;

                case "2":
                    break;

                case "3":
                    break;

                case "4":
                    MainMenu.HomeScreen();
                    break;

                default:
                    AnsiConsole.MarkupLine(@"[rapidblink][maroon]Invalid Response![/][/]
                                                Please choose an option [bold][underline]listed above[/][/]. Thank you");
                    break;
            }



        }
        
    }
}
