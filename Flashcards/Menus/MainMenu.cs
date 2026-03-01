using Spectre.Console;

namespace Flashcards.Menus
{
    internal class MainMenu
    {

        internal static void HomeScreen()
        {
            Console.Clear();
            AnsiConsole.MarkupLine("[slowblink][Blue]Welcome to the Flashcards app![/][/]");
            Console.WriteLine();
            AnsiConsole.MarkupLine("1. Add a new stack, or a new flashcard to an existing stack. -- Not yet functional");
            AnsiConsole.MarkupLine("2. Study -- Not yet functional");
            AnsiConsole.MarkupLine("3. Delete flashcards -- Not yet functional");
            AnsiConsole.MarkupLine("4. View History -- Not yet functional");
            AnsiConsole.MarkupLine("[maroon]5. Exit Application[/]");


            string temp = Console.ReadLine();

            switch (temp)
            {
                case "1":
                    CardCreation.CreationMenu();
                    break;

                case "2":
                    break;

                case "3":
                    break;

                case "4":
                    break;

                case "5":
                    Environment.Exit(0);
                    break;

                default:
                    AnsiConsole.MarkupLine("[rapidblink][maroon]Invalid Response![/][/] Please choose an option [bold][underline]listed above[/][/]. Thank you");
                    break;
            }
        }


    }
}
