namespace Flashcards.DTO
{
    internal class FlashcardDTO
    {
        public int FlashcardID { get; set; }
        public required string Question { get; set; }
        public required string Answer { get; set; }
        
        //dont think I need that below
        //public int StackID { get; set; }

    }
}
