using Spectre.Console;
namespace Flashcards.Menus
{
    internal class DeleteMenu
    {
        internal static void DeleteMenus()
        {
            Console.Clear();

            Console.WriteLine("Welcome to the delete menu. What do you want to delete?");
            Console.WriteLine();
            AnsiConsole.MarkupLine("[maroon][rapidblink] WARNING!![/][/] Deleting a subject will delete all flashcards within the subject");
            Console.WriteLine();
            AnsiConsole.MarkupLine("[green]1. Individual Flashcard[/]");
            AnsiConsole.MarkupLine("[red]2. An entire subject[/]");
            AnsiConsole.MarkupLine("3. Return to the main menu.");

            string temp = Console.ReadLine();

            switch (temp)
            {
                case "1":
                    break;

                case "2":
                    Stack_Ops.DeleteStacks.DeleteStack();
                    break;

                case "3":
                    MainMenu.HomeScreen();
                    break;

                default:
                    Console.Clear();
                    AnsiConsole.MarkupLine("[rapidblink][maroon]Invalid Response![/][/] Please choose a [bold][underline]valid option from the list[/][/].");
                    AnsiConsole.Status()
                         .Start("Regenerating options...", ctx =>
                         {
                             ctx.Spinner(Spinner.Known.Aesthetic);
                             Thread.Sleep(3000);
                         });
                    DeleteMenus();
                    break;

            }
        }
    }
}
