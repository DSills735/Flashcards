

namespace Flashcards.Stack_Ops
{

    //TODO Need to finish the create a card portion before I finish this. 
    internal class UpdateStack
    {
        public static void UpdateStacks()
        {
            Console.Clear();

            Console.WriteLine("What subject are you going to add a card to?");

            Console.WriteLine("--------------------------------------------------");

            Database_Helpers.ViewStacks.DisplayStacksForUpdate();

            Console.WriteLine();

            Console.WriteLine("Please enter the ID of the subject you are adding to");

            int id = Convert.ToInt32(Console.ReadLine());

            

        }

    }
}
